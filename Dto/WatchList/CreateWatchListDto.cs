using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.WatchList
{
    public class CreateWatchListDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int MovieId { get; set; }
    }
}
