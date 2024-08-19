using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.Directors
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly ApplicationDbContext _context;

        public DirectorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateDirector(Director director)
        {
            try
            {
                _context.Directors.Add(director);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating director");
            }
        }

        public void DeleteDirector(Director director)
        {
            try
            {
                _context.Directors.Remove(director);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting actor");
            }
        }

        public List<Director> GetAllDirector()
        {
            try
            {
                return _context.Directors
                    .Include(d => d.Movies).ThenInclude(d => d.Genre)
                    .Include(d => d.Movies).ThenInclude(d => d.MovieMedias)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all actor");
            }
        }

        public Director GetDirectorById(int id)
        {
            try
            {
                return _context.Directors
                    .AsNoTracking()
                    .FirstOrDefault(u => u.DirectorId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting director");
            }
        }

        public void UpdateDirector(Director director)
        {
            try
            {
                _context.Entry<Director>(director).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating director");
            }
        }
    }
}
