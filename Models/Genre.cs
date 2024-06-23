using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sever.Models
{
    public class Genre : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenreId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Movie>? Movies { get; set; }
    }
}
