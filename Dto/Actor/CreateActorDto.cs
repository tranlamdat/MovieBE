using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Actor
{
    public class CreateActorDto : BaseDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime DoB { get; set; }

        [Required]
        public string Nationality { get; set; }

        public string? AvatarUrl { get; set; }

        public string? PublicId { get; set; }

        public IFormFile? NewAvatar { get; set; }
    }
}
