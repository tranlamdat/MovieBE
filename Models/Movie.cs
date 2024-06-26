using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sever.Models
{
    public class Movie : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string PosterImage { get; set; }

        [Required]
        public string BannerImage { get; set; }

        [Required]
        public string MovieUrl { get; set; }

        [Required]
        public string National { get; set; }

        [Required]
        public int NumberOfView { get; set; } = 0;

        [Required]
        public int GenreId { get; set; }

        [Required]
        public int DirectorId { get; set; }

        [ForeignKey("GenreId")]
        public virtual Genre? Genre { get; set; }

        [ForeignKey("DirectorId")]
        public virtual Director? Director { get; set; }

        public virtual ICollection<MovieActor>? MovieActors { get; set; }

        public virtual ICollection<WatchList>? WatchLists { get; set; }
    }
}
