using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models;

public class CreateUserDto
{
    [Required] public string UserName { get; set; } = null!;
    [Required, MinLength(6)] public string Password { get; set; } = null!;
}