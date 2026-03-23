using System.ComponentModel.DataAnnotations;

namespace api_auth.Application.DTOs
{
    public class RegisterUserDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = null!;
    }
}
