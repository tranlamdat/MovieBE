using AutoMapper;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sever.Constraints;
using Sever.Dto.User;
using Sever.Exceptions;
using Sever.Models;
using Sever.Repository.Users;
using Sever.Services.Cloudinaries;
using System;

namespace Sever.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IClodinaryService _clodinaryService;

        public UserService(IUserRepository userRepository, IMapper mapper, IClodinaryService clodinaryService)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _clodinaryService = clodinaryService;
        }

        public UserDto CreateUser(CreateUserDto userDto)
        {
            // Get user by email
            User user = _userRepository.GetUserByEmail(userDto.Email);
            if (user != null)
            {
                throw new ConflictException("Email already exists");
            }

            // Hash password
            var passwordHasher = new PasswordHasher<string>();
            userDto.Password = passwordHasher.HashPassword(null, userDto.Password);

            // Map registerDto to user
            user = _mapper.Map<User>(userDto);

            // Create user
            _userRepository.CreateUser(user);

            return _mapper.Map<UserDto>(_userRepository.GetUserById(user.UserId));
        }

        public string DeleteUser(int id)
        {
            User user = _userRepository.GetUserById(id) ?? throw new NotFoundException("User not found");
            _userRepository.DeleteUser(user);

            return "User deleted successfully";
        }

        public List<UserDto> GetAllUser()
        {
            List<User> users = _userRepository.GetAllUser();
            return _mapper.Map<List<UserDto>>(users);
        }

        public UserDto GetUserById(int id)
        {
            User user = _userRepository.GetUserById(id) ?? throw new NotFoundException("User not found");
            return _mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> UpdateUser(int id, UpdateUserDto updateUserDto)
        {
            User user = _userRepository.GetUserById(id) ?? throw new NotFoundException("User not found");
            updateUserDto.UserId = id;

            if (updateUserDto.Password != null)
            {
                updateUserDto.Password = HashPassword(updateUserDto.Password);
            }
            else
            {
                updateUserDto.Password = user.Password;
            }

            // Save profile picture
            if (updateUserDto.NewProfilePicture != null)
            {
                var result = await _clodinaryService.UploadImageAsync(updateUserDto.NewProfilePicture, EFileType.PROFILE.ToString());
                if (result.Error != null) throw new InvalidException(result.Error.Message);

                updateUserDto.ProfilePicture = result.SecureUri.AbsoluteUri;
            }

            user = _mapper.Map<User>(updateUserDto);
            _userRepository.UpdateUser(user);

            return _mapper.Map<UserDto>(user);
        }

        public string ChangePassword(int userId, ChangePasswordDto changePasswordDto)
        {
            User user = _userRepository.GetUserById(userId) ?? throw new NotFoundException("User not found");

            if (!VerifyPassword(user.Password, changePasswordDto.CurrentPassword))
            {
                throw new InvalidException("Current password is incorrect");
            }

            user.Password = HashPassword(changePasswordDto.NewPassword);
            _userRepository.UpdateUser(user);

            return "Password changed successfully";
        }

        public bool VerifyPassword(string currentPassword, string oldPassword)
        {
            var passwordHasher = new PasswordHasher<string>();
            if (passwordHasher.VerifyHashedPassword(null, currentPassword, oldPassword) == PasswordVerificationResult.Failed)
            {
                return false;
            }
            return true;
        }

        public string HashPassword(string newPassword)
        {
            var passwordHasher = new PasswordHasher<string>();
            return passwordHasher.HashPassword(null, newPassword);
        }
    }
}
