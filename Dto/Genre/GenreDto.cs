using Sever.Dto.Movie;

namespace Sever.Dto.Genre
{
    public class GenreDto : BaseDto
    {
        public int GenreId { get; set; }

        public string Name { get; set; }

        public List<MovieDto> Movies { get; set; }
    }
}
