using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Sever.Constraints;
using Sever.Dto.Auth;
using Sever.Dto.User;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Roles;
using Sever.Repository.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Sever.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;

        public AuthService(IMapper mapper, IUserRepository userRepository, IRoleRepository roleRepository)

        {
            _mapper = mapper;
            _userRepository = userRepository;
            _roleRepository = roleRepository;
        }

        public string Register(RegisterDto registerDto)
        {
            // Get user by email
            User user = _userRepository.GetUserByEmail(registerDto.Email);
            if (user != null)
            {
                throw new ConflictException("Email already exists");
            }

            // Hash password
            var passwordHasher = new PasswordHasher<string>();
            registerDto.Password = passwordHasher.HashPassword(null, registerDto.Password);

            // Map registerDto to user
            user = _mapper.Map<User>(registerDto);

            // Get role by name
            Role role = _roleRepository.GetRoleByName(ERole.Member.ToString()) ?? throw new NotFoundException("Role not found");
            user.RoleId = role.RoleId;

            user.DateCreated = DateTime.UtcNow;
            user.DateUpdated = DateTime.UtcNow;

            // Create user
            _userRepository.CreateUser(user);

            return "Register success!";
        }

        public AuthResponse Login(LoginDto loginDto)
        {
            // Get user by email
            User user = _userRepository.GetUserByEmail(loginDto.Email) ?? throw new AuthenticationException("Invalid Credentials!");

            // Verify password
            var passwordHasher = new PasswordHasher<string>();
            if (passwordHasher.VerifyHashedPassword(null, user.Password, loginDto.Password) == PasswordVerificationResult.Failed)
            {
                throw new AuthenticationException("Invalid Credentials!");
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY"));
            TimeSpan tokenLifeTime = TimeSpan.FromMinutes(Convert.ToDouble(Environment.GetEnvironmentVariable("JWT_TOKEN_LIFE_TIME")));

            var claims = new List<Claim>
            {
                new(JwtRegisteredClaimNames.Sub, Environment.GetEnvironmentVariable("JWT_SUBJECT")),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new("userId", user.UserId.ToString()),
                new(ClaimTypes.Role, user.Role.Name),
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(tokenLifeTime),
                Issuer = Environment.GetEnvironmentVariable("JWT_ISSUER"),
                Audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            string accessToken = tokenHandler.WriteToken(token);

            UserDto userDto = _mapper.Map<UserDto>(user);

            return new AuthResponse { AccessToken = accessToken, User = userDto };
        }
    }
}
