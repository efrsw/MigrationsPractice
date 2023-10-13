using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int Id { get; set; }
    public string Tags { get; set; }
    public List<Tags> PostTags { get; set; }
}