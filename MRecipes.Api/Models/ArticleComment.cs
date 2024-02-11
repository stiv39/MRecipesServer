namespace MRecipes.Api.Models;

public class ArticleComment
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
    public Guid ArticleId { get; set; }
    public Article Article { get; set; }
}
