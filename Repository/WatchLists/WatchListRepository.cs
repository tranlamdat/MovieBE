using Microsoft.EntityFrameworkCore;
using Sever.Models;

namespace Sever.Repository.WatchLists
{
    public class WatchListRepository : IWatchListRepository
    {
        private readonly ApplicationDbContext _context;

        public WatchListRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateWatchList(WatchList watchList)
        {
            try
            {
                _context.WatchLists.Add(watchList);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error creating watch list");
            }
        }

        public void DeleteWatchList(WatchList watchList)
        {
            try
            {
                _context.WatchLists.Remove(watchList);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error deleting watch list");
            }
        }

        public WatchList GetWatchListById(int id)
        {
            try
            {
                return _context.WatchLists
                    .AsNoTracking()
                    .FirstOrDefault(x => x.WatchListId == id);
            }
            catch (Exception)
            {
                throw new Exception("Error getting watch list");
            }
        }

        public WatchList GetWatchListByUserIdAndMovieId(int userId, int movieId)
        {
            try
            {
                return _context.WatchLists
                    .AsNoTracking()
                    .FirstOrDefault(x => x.UserId == userId && x.MovieId == movieId);
            }
            catch (Exception)
            {
                throw new Exception("Error getting watch list");
            }
        }

        public List<WatchList> GetWatchListByUserId(int userId)
        {
            try
            {
                return _context.WatchLists
                    .Include(wl => wl.Movie)
                    .Include(wl => wl.Movie.Genre)
                    .Include(wl => wl.Movie.Director)
                    .Include(wl => wl.Movie.MovieActors)
                    .Include(wl => wl.Movie.MovieMedias)
                    .AsNoTracking()
                    .Where(x => x.UserId == userId)
                    .ToList();
            }
            catch (Exception)
            {
                throw new Exception("Error getting watch list");
            }
        }

        public void UpdateWatchList(WatchList watchList)
        {
            try
            {
                _context.Entry<WatchList>(watchList).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Error updating watch list");
            }
        }
    }
}
