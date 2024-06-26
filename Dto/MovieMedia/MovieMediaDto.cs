using Sever.Constraints;
using Sever.Dto.Movie;

namespace Sever.Dto.MovieMedia
{
    public class MovieMediaDto
    {
        public int MovieMediaId { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public string PublicId { get; set; }

        public EFileType Type { get; set; }

        public MovieDto? Movie { get; set; }
    }
}
