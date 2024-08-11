using Sever.Dto.Movie;

namespace Sever.Dto.WatchList
{
    public class WatchListDto
    {
        public int WatchListId { get; set; }

        public int UserId { get; set; }

        public MovieDto Movie { get; set; }

    }
}
