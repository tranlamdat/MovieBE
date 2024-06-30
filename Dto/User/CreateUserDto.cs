using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.User
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "The email can not empty!")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public IFormFile? ProfilePicture { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}
