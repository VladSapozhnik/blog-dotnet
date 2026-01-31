using BlogApplication.Domain.Entities;
using BlogApplication.Domain.Interfaces;
using BlogApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApplication.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BlogsController : Controller
{
    private readonly IBlogRepository _blogRepository;

    public BlogsController(IBlogRepository blogRepository)
    {
        _blogRepository = blogRepository;
    }
    
    
    [HttpPost]
    public IActionResult CreateBlog([FromBody] CreateBlogDto model)
    {
        if (!ModelState.IsValid)
            throw new BadHttpRequestException("Invalid date");

        var newBlog = new BlogEntity
        {
            Name = model.name,
            Description = model.description,
            WebsiteUrl = model.websiteUrl
        };
        
        var blog = _blogRepository.CreateBlog(newBlog);

        return Ok(blog);
    }

    [HttpGet]
    public IActionResult GetAllBlogs()
    {
        var users = _blogRepository.GetBlogs();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetBlog(Guid id)
    {
        var user = _blogRepository.GetBlog(id);
        return Ok(user);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBlog(Guid id, [FromBody] UpdateBlogDto model)
    {
        _blogRepository.UpdateBlog(id, model);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveBlog(Guid id)
    {
        _blogRepository.RemoveBlog(id);
        
        return NoContent();
    }
}