using Sever.Models;

namespace Sever.Repository.Users
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        User GetUserByEmail(string email);
        User GetUserById(int id);
        void UpdateUser(User user);
        void DeleteUser(User user);
        List<User> GetAllUser();
    }
}
