namespace WebApplication1.Models;

using System.ComponentModel.DataAnnotations;

public class CreateUserDto
{
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required] public string UserName { get; set; } = null!;
    [Required, MinLength(6)] public string Password { get; set; } = null!;
}