using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.MovieActors
{
    public class MovieActorRepository : IMovieActorRepository
    {
        private readonly ApplicationDbContext _context;

        public MovieActorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateMovieActor(MovieActor movieActor)
        {
            try
            {
                _context.MovieActors.Add(movieActor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating movie actor");
            }
        }

        public void DeleteMovieActor(MovieActor movieActor)
        {
            try
            {
                _context.MovieActors.Remove(movieActor);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting movie actor");
            }
        }

        public List<MovieActor> GetAllMovieActor()
        {
            try
            {
                return _context.MovieActors
                    .Include(m => m.Movie)
                    .Include(m => m.Actor)
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting all movie actors");
            }
        }

        public MovieActor GetMovieActorById(int id)
        {
            try
            {
                return _context.MovieActors
                    .Include(m => m.Movie)
                    .Include(m => m.Actor)
                    .AsNoTracking()
                    .FirstOrDefault(u => u.MovieActorId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting movie actor");
            }
        }

        public void UpdateMovieActor(MovieActor movieActor)
        {
            try
            {
                _context.Entry<MovieActor>(movieActor).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating movie actor");
            }
        }
    }
}
