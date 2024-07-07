using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Sever.Constraints;

namespace Sever.Models
{
    public class MovieMedia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieMediaId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string PublicId { get; set; }

        public EFileType Type { get; set; }

        public int MovieId { get; set; }

        [ForeignKey("MovieId")]
        public virtual Movie? Movie { get; set; }
    }
}
