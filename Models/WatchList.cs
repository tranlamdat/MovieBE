using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sever.Models
{
    public class WatchList : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WatchListId { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
        
        [ForeignKey("MovieId")]
        public virtual Movie? Movie { get; set; }
    }
}
