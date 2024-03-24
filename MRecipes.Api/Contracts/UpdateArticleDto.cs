namespace MRecipes.Api.Contracts;

public class UpdateArticleDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Steps { get; set; }
    public string Tags { get; set; }
    public string Ingredients { get; set; }
}
