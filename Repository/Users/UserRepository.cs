using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating user");
            }
        }

        public User GetUserByEmail(string email)
        {
            try
            {
                User user = _context.Users
                    .Include(u => u.Role)
                    .FirstOrDefault(u => u.Email == email);

                return user;
            }
            catch (Exception)
            {
                throw new Exception("Error getting user");
            }
        }

        public User GetUserById(int id)
        {
            try
            {
                return _context.Users
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.UserId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting user");
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                _context.Entry<User>(user).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating user");
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting user");
            }
        }

        public List<User> GetAllUser()
        {
            try
            {
                return _context.Users
                    .Include(u => u.Role)
                    .AsNoTracking()
                    .Where(u => u.Email != "admin@gmail.com")
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all user");
            }
        }
    }
}
