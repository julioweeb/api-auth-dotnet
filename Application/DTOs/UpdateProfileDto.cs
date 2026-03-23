using System.ComponentModel.DataAnnotations;

namespace api_auth.Application.DTOs
{
    public class UpdateProfileDto
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = string.Empty;
    }
}
