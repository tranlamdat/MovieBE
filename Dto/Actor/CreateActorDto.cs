using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Actor
{
    public class CreateActorDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DoB { get; set; }

        [Required]
        public string Nationality { get; set; }
    }
}
