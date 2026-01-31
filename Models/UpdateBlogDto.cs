using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models;

public class UpdateBlogDto
{
    
    [Required] public string Name { get; set; } = null!;
    [Required] public string Description { get; set; } = null!;
    [Required] public string WebsiteUrl { get; set; } = null!;
}