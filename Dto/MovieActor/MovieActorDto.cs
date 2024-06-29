using Sever.Dto.Actor;
using Sever.Dto.Movie;

namespace Sever.Dto.MovieActor
{
    public class MovieActorDto : BaseDto
    {
        public int MovieActorId { get; set; }

        public MovieDto? Movie { get; set; }

        public ActorDto? Actor { get; set; }

        public string CharacterName { get; set; }
    }
}
