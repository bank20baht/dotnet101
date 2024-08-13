using Microsoft.EntityFrameworkCore;
using CleanDotnet.Model;
public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; } = null!;
}