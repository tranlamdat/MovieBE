using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.Contact
{
    public class CreateContactDto : BaseDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
