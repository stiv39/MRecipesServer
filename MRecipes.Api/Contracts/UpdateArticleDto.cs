namespace MRecipes.Api.Contracts;

public class UpdateArticleDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Steps { get; set; } = [];
    public string Tags { get; set; } = string.Empty;
    public string Ingredients { get; set; } = string.Empty;
}
