using Sever.Dto.User;

namespace Sever.Services.Users
{
    public interface IUserService
    {
        UserDto CreateUser(CreateUserDto userDto);
        UserDto GetUserById(int id);
        Task<UserDto> UpdateUser(int id, UpdateUserDto updateUserDto);
        string DeleteUser(int id);
        List<UserDto> GetAllUser();
        string ChangePassword(int userId, ChangePasswordDto changePasswordDto);
    }
}
