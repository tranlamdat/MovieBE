using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sever.Models
{
    public class WatchList : Base
    {
        public int UserId { get; set; }

        public int MovieId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
        
        [ForeignKey("MovieId")]
        public virtual Movie? Movie { get; set; }
    }
}
