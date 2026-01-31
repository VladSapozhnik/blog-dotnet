using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models;

public class CreateBlogDto
{
    [Required] public string name { get; set; } = null!;
    [Required] public string description { get; set; } = null!;
    [Required] public string websiteUrl { get; set; } = null!;
}