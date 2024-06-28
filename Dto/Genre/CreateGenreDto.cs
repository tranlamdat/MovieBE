using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Genre
{
    public class CreateGenreDto
    {
        [Required]
        public string Name { get; set; }
    }
}
