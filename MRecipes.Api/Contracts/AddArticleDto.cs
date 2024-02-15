namespace MRecipes.Api.Contracts;

public class AddArticleDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Steps { get; set; }
    public string Tags { get; set; }
    public string Ingredients { get; set; }
}
