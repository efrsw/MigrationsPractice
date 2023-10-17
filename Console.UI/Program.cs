namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        //PopulateData();
        AddPostWithTag();
    }
    public static void AddPostWithTag()
    {
        using var _db = new BlogsContext();

        var tagA = _db.Tags.Where(t => t.Name == "A").First();

        _db.Add(new Post()
        {
            Tags = "",
            PostTags = new List<Tags>() { tagA }
        });
        _db.SaveChanges();
    }

    public static void PopulateData()
    {
        using var _db = new BlogsContext();

        var post1 = new Post()
        {
            Tags = "",
            PostTags = new List<Tags>()
        };

        var post2 = new Post()
        {
            Tags = "",
            PostTags = new List<Tags>()
        };

        var tagA = new Tags()
        {
            Name = "A",
            Posts = new List<Post>() { post1, post2 }
        };

        var tagB = new Tags()
        {
            Name = "B",
            Posts = new List<Post>() { post1 }
        };

        post1.PostTags.AddRange(new List<Tags>() { tagA, tagB });
        post2.PostTags.Add(tagA);

        _db.Add(post1);
        _db.Add(post2);

        _db.SaveChanges();
    }
}