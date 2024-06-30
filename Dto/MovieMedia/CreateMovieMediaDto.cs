using Sever.Constraints;
using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.MovieMedia
{
    public class CreateMovieMediaDto
    {
        public int MovieId { get; set; }

        public EFileType Type { get; set; }

        [Required(ErrorMessage = "The file can not empty!")]
        public IFormFile FileUpload { get; set; }
    }
}
