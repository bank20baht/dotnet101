using Microsoft.EntityFrameworkCore;

public class CleanDotnetContext : DbContext
{
    public CleanDotnetContext(DbContextOptions<CleanDotnetContext> options)
        : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<User> Users { get; set; } = null!;
}