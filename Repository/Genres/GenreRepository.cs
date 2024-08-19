using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.Genres
{
    public class GenreRepository : IGenreRepository
    {
        private readonly ApplicationDbContext _context;

        public GenreRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateGenre(Genre genre)
        {
            try
            {
                _context.Genres.Add(genre);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating genre");
            }
        }

        public void DeleteGenre(Genre genre)
        {
            try
            {
                _context.Genres.Remove(genre);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting genre");
            }
        }

        public List<Genre> GetAllGenre()
        {
            try
            {
                return _context.Genres
                    .Include(g => g.Movies).ThenInclude(g => g.MovieMedias)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all genre");
            }
        }

        public Genre GetGenreById(int id)
        {
            try
            {
                return _context.Genres
                    .AsNoTracking()
                    .FirstOrDefault(u => u.GenreId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting genre");
            }
        }

        public void UpdateGenre(Genre genre)
        {
            try
            {
                _context.Entry<Genre>(genre).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating genre");
            }
        }
    }
}
