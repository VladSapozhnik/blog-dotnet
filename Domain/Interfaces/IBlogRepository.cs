using BlogApplication.Domain.Entities;
using BlogApplication.Models;

namespace BlogApplication.Domain.Interfaces;

public interface IBlogRepository
{
    BlogEntity CreateBlog(BlogEntity newBlog);
    IEnumerable<BlogEntity> GetBlogs();
    BlogEntity GetBlog(Guid id);
    void UpdateBlog(Guid id, UpdateBlogDto blog);
    void RemoveBlog(Guid id);
}