using Sever.Dto.MovieActor;

namespace Sever.Dto.Actor
{
    public class ActorDto : BaseDto
    {
        public int ActorId { get; set; }

        public string Name { get; set; }

        public DateTime DoB { get; set; }

        public string Nationality { get; set; }

        public string? AvatarUrl { get; set; }

        public string? PublicId { get; set; }

        public List<MovieActorDto> MovieActors { get; set; }
    }
}
