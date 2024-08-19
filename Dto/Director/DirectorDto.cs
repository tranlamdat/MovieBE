using Sever.Dto.Movie;

namespace Sever.Dto.Director
{
    public class DirectorDto : BaseDto
    {
        public int DirectorId { get; set; }

        public string Name { get; set; }

        public DateTime DoB { get; set; }

        public string Nationality { get; set; }

        public string? AvatarUrl { get; set; }

        public string? PublicId { get; set; }

        public List<MovieDto> Movies { get; set; }
    }
}
