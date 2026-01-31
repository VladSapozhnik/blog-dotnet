namespace BlogApplication.Domain.Entities;

public class UserEntity
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}