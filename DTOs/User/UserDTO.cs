using System.ComponentModel.DataAnnotations;

namespace coink_api.DTOs.User;

public class UserDTO
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    [RegularExpression(@"^\d+$", ErrorMessage = "Only numbers are allowed")]
    public string Phone { get; set; } = string.Empty;
    [Required]
    public string Country { get; set; } = string.Empty;
    [Required]
    public string Department { get; set; } = string.Empty;
    [Required]
    public string Town { get; set; } = string.Empty;
    [Required]
    public string Address { get; set; } = string.Empty;
}