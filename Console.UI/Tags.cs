using System.ComponentModel.DataAnnotations;

public class Tags
{
    [Key]
    public int Id { get; set; }
    public IEnumerable<Post> Posts { get; set; }
}