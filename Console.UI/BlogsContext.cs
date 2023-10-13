using Microsoft.EntityFrameworkCore;

public class BlogsContext : DbContext
{
    public string DbPath { get; }
    public virtual DbSet<Tags> Tags { get; set; }
    public virtual DbSet<Post> Posts { get; set; }

    public BlogsContext()
    {
        DbPath = @"C:\dev\cs\MigrationsPractice\blogs.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}