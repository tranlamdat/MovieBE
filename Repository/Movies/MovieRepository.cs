using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateMovie(Movie movie)
        {
            try
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating movie");
            }
        }

        public void DeleteMovie(Movie movie)
        {
            try
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting movie");
            }
        }

        public List<Movie> GetAllMovie()
        {
            try
            {
                return _context.Movies
                    .Include(m => m.Genre)
                    .Include(m => m.Director)
                    .Include(m => m.MovieActors)
                    .Include(m => m.MovieMedias)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all movies");
            }
        }

        public Movie GetMovieById(int id)
        {
            try
            {
                return _context.Movies
                    .Include(m => m.Genre)
                    .Include(m => m.Director)
                    .Include(m => m.MovieActors).ThenInclude(ma => ma.Actor)
                    .Include(m => m.MovieMedias)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.MovieId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting movie");
            }
        }

        public void UpdateMovie(Movie movie)
        {
            try
            {
                _context.Entry<Movie>(movie).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating movie");
            }
        }
    }
}
