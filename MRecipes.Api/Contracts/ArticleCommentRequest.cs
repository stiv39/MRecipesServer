namespace MRecipes.Api.Contracts;

public class ArticleCommentRequest
{
    public Guid ArticleId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
