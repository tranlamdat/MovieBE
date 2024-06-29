using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.MovieActor
{
    public class CreateMovieActorDto
    {
        [Required]
        public int MovieId { get; set; }

        [Required]
        public int ActorId { get; set; }

        [Required]
        public string CharacterName { get; set; }
    }
}
