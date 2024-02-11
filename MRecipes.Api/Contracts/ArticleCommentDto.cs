namespace MRecipes.Api.Contracts;

public class ArticleCommentDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
}
