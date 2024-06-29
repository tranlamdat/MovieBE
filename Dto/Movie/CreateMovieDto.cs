using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Movie
{
    public class CreateMovieDto
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        public string National { get; set; }

        [Required]
        public int NumberOfView { get; set; } = 0;

        [Required]
        public int GenreId { get; set; }

        [Required]
        public int DirectorId { get; set; }
    }
}
