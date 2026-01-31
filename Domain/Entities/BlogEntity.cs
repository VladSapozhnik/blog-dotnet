namespace BlogApplication.Domain.Entities;

public class BlogEntity
{
    public Guid Id { get; set; } =  Guid.NewGuid();
    public required string Name { get; set; } 
    public required string Description { get; set; }
    public required string WebsiteUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsMembership { get; set; } = false;
}