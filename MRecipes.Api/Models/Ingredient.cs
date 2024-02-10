namespace MRecipes.Api.Models;

public class Ingredient
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid ArticleId { get; set; }
    public Article Article { get; set; }
}
