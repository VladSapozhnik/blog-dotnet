using BlogApplication.Domain.Entities;
using BlogApplication.Domain.Interfaces;
using BlogApplication.Models;

namespace BlogApplication.Infrastructure.Repositories;

public class BlogsRepository: IBlogRepository
{
    private static List<BlogEntity> _blogs = new List<BlogEntity>();
    public BlogEntity CreateBlog(BlogEntity newBlog)
    {
        _blogs.Add(newBlog);

        return newBlog;
    }
    public IEnumerable<BlogEntity> GetBlogs()
    {
        return _blogs;
    }
    public  BlogEntity GetBlog(Guid id)
    {
        var blog = _blogs.FirstOrDefault(x => x.Id == id);
        
        if (blog == null) throw new Exception("Blog not found");
        
        return blog;
    }

    public void UpdateBlog(Guid id, UpdateBlogDto dto)
    {
        var existingBlog = GetBlog(id);

        existingBlog.Name = dto.Name;
        existingBlog.WebsiteUrl = dto.WebsiteUrl;
        existingBlog.Description = dto.Description;
    }

    public void RemoveBlog(Guid id)
    {
        var blog = GetBlog(id);
        
        if (blog == null) throw new Exception("Blog not found");
        
        _blogs.Remove(blog);
    }
}