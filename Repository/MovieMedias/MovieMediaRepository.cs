using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.MovieMedias
{
    public class MovieMediaRepository : IMovieMediaRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieMediaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateMovieMedia(MovieMedia movieMedia)
        {
            try
            {
                _context.MoviesMedias.Add(movieMedia);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating file");
            }
        }

        public void DeleteMovieMedia(MovieMedia movieMedia)
        {
            try
            {
                _context.MoviesMedias.Remove(movieMedia);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting file");
            }
        }

        public MovieMedia GetMovieMediaById(int id)
        {
            try
            {
                return _context.MoviesMedias
                    .AsNoTracking()
                    .FirstOrDefault(x => x.MovieMediaId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting file");
            }
        }

        public List<MovieMedia> GetMovieMediaByMovieId(int movieId)
        {
            try
            {
                return _context.MoviesMedias
                    .AsNoTracking()
                    .Where(x => x.MovieId == movieId)
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting file");
            }
        }

        public void UpdateMovieMedia(MovieMedia movieMedia)
        {
            try
            {
                _context.Entry<MovieMedia>(movieMedia).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating file");
            }
        }
    }
}
