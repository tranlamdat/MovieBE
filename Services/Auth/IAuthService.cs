using Sever.Dto.Auth;

namespace Sever.Services.Auth
{
    public interface IAuthService
    {
        string Register(RegisterDto registerDto);
        AuthResponse Login(LoginDto loginDto);
    }
}
