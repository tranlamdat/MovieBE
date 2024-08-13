using System.ComponentModel.DataAnnotations;

namespace Sever.Dto.User
{
    public class CreateUserDto : BaseDto
    {
        [Required(ErrorMessage = "The email can not empty!")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string? Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public bool? Gender { get; set; }

        public string? Telephone { get; set; }

        public string? ProfilePicture { get; set; }

        public IFormFile? NewProfilePicture { get; set; }

        [Required]
        public int RoleId { get; set; }
    }
}
