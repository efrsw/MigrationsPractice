using System.ComponentModel.DataAnnotations;

public class Tags
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Post> Posts { get; set; }
}