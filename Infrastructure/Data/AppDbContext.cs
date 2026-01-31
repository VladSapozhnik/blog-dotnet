using Microsoft.EntityFrameworkCore;
using BlogApplication.Domain.Entities;

namespace BlogApplication.Infrastructure.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<UserEntity> users { get; set; }
}