using System.ComponentModel.DataAnnotations;

namespace api_auth.Application.DTOs
{
    public class UpdatePasswordDto
    {
        [Required]
        public string CurrentPassword { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        public string NewPassword { get; set; } = string.Empty;
    }
}
