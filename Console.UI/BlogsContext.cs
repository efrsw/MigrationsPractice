using Microsoft.EntityFrameworkCore;

public class BlogsContext : DbContext
{
    public string DbPath { get; }
    public virtual DbSet<Tags> Tags { get; set; }
    public virtual DbSet<Post> Posts { get; set; }

    public BlogsContext()
    {
        DbPath = @"Server=(localdb)\MSSQLLocalDB;Database=office_test;Trusted_Connection=True;MultipleActiveResultSets=true;Persist Security Info=False;";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DbPath);    
    }
}