using Sever.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Sever.Dto.Role;

namespace Sever.Dto.User
{
    public class UserDto : BaseDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ProfilePicture { get; set; }
        public RoleDto? Role { get; set; }
    }
}
