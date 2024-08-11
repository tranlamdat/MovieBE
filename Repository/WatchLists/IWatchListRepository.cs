using Sever.Models;

namespace Sever.Repository.WatchLists
{
    public interface IWatchListRepository
    {
        void CreateWatchList(WatchList watchList);
        WatchList GetWatchListById(int id);
        List<WatchList> GetWatchListByUserId(int userId);
        void UpdateWatchList(WatchList watchList);
        void DeleteWatchList(WatchList watchList);
        WatchList GetWatchListByUserIdAndMovieId(int userId, int movieId);
    }
}
