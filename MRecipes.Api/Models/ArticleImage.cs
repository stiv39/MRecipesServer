namespace MRecipes.Api.Models;

public class ArticleImage
{
    public Guid Id { get; set; }
    public Guid ArticleId { get; set; }
    public byte[] Image { get; set; }
    public Article Article { get; set; }
}
