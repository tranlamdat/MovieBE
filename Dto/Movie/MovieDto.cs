using Sever.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Movie
{
    public class MovieDto
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string National { get; set; }

        public int NumberOfView { get; set; } = 0;

        public int GenreId { get; set; }

        public int DirectorId { get; set; }
    }
}
