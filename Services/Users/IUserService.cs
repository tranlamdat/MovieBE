using Sever.Dto.User;

namespace Sever.Services.Users
{
    public interface IUserService
    {
        UserDto CreateUser(CreateUserDto userDto);
        UserDto GetUserById(int id);
        UserDto UpdateUser(int id, UpdateUserDto updateUserDto);
        string DeleteUser(int id);
        List<UserDto> GetAllUser();
    }
}
