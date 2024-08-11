using Sever.Dto.WatchList;

namespace Sever.Services.WatchLists
{
    public interface IWatchListService
    {
        WatchListDto AddWatchList(CreateWatchListDto createWatchListDto);

        string DeleteWatchList(int id);

        List<WatchListDto> GetAllWatchListByUserId(int userId);
    }
}
