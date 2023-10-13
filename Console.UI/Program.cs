namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        PopulateData();
    }

    public static void PopulateData()
    {
        using var _db = new BlogsContext();
        Tags a = new Tags()
        {
            Name = "A",
            Posts = new List<Post>()
        };

        Tags b = new Tags()
        {
            Name = "B",
            Posts = new List<Post>()
        };

        Post p1 = new Post()
        {
            Tags = "",
            PostTags = new List<Tags>() { a, b }
        };

        Post p2 = new Post()
        {
            Tags = "",
            PostTags = new List<Tags>()
        };

        b.Posts.Add(p1);
        a.Posts.Add(p2);

        _db.Posts.Add(p1);
        _db.SaveChanges();
    }
}