using Sever.Dto.Director;
using Sever.Dto.Genre;
using Sever.Dto.MovieActor;
using Sever.Dto.MovieMedia;

namespace Sever.Dto.Movie
{
    public class MovieDto : BaseDto
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string National { get; set; }

        public int NumberOfView { get; set; }

        public GenreDto? Genre { get; set; }

        public DirectorDto? Director { get; set; }

        public ICollection<MovieMediaDto>? MovieMedias { get; set; }

        public ICollection<MovieActorDto>? MovieActors { get; set; }
    }
}
