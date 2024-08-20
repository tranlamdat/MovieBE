using Microsoft.EntityFrameworkCore;
using Sever.Constraints;
using Sever.Helpers;
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

        public List<Movie> GetMoviesByWeek()
        {
            try
            {
                var startOfWeek = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                var endOfWeek = DateTime.Now.EndOfWeek(DayOfWeek.Monday);

                return _context.Movies
                    .Include(m => m.Genre)
                    .Include(m => m.Director)
                    .Include(m => m.MovieActors)
                    .Include(m => m.MovieMedias)
                    .Where(m => m.ReleaseDate >= startOfWeek && m.ReleaseDate <= endOfWeek)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all movies");
            }
        }

        public List<Movie> GetMoviesComingSoon()
        {
            try
            {
                var today = DateTime.Now.Date;

                return _context.Movies
                    .Include(m => m.Genre)
                    .Include(m => m.Director)
                    .Include(m => m.MovieActors)
                    .Include(m => m.MovieMedias)
                    .Where(m => m.ReleaseDate >= today)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all movies");
            }
        }

        public List<Movie> GetMoviesRelatedByGenre(int genreId)
        {
            try
            {
                var today = DateTime.Now.Date;

                return _context.Movies
                    .Include(m => m.Genre)
                    .Include(m => m.Director)
                    .Include(m => m.MovieActors)
                    .Include(m => m.MovieMedias)
                    .Where(m => m.GenreId == genreId && m.ReleaseDate < today)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all movies");
            }
        }

        public List<Movie> SearchMovie(string name, string type)
        {
            try
            {
                if (String.Equals(EMovieSearchType.name.ToString().ToLower(), type.ToLower()))
                {
                    return _context.Movies
                       .Include(m => m.Genre)
                       .Include(m => m.Director)
                       .Include(m => m.MovieActors)
                       .Include(m => m.MovieMedias)
                       .Where(p => p.Title.ToLower().Contains(name.ToLower()))
                       .ToList();
                }
                else
                {
                    return _context.Movies
                       .Include(m => m.Genre)
                       .Include(m => m.Director)
                       .Include(m => m.MovieActors)
                       .Include(m => m.MovieMedias)
                       .Where(p => p.Genre.Name.ToLower().Contains(name.ToLower()))
                       .ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error searching movie");
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
