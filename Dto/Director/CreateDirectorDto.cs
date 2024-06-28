using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Director
{
    public class CreateDirectorDto
    {
        [Required]
        public string Name { get; set; }

        public DateTime DoB { get; set; }

        [Required]
        public string Nationality { get; set; }
    }
}
