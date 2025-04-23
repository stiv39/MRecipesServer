namespace MRecipes.Api.Contracts;

public class ArticleDetailsDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public DateTime DateAdded { get; set; }
    public string Image { get; set; }
    public List<string> Steps { get; set; }
    public List<string> Tags { get; set; }
    public List<string> Ingredients { get; set; }
    public List<ArticleCommentDto> ArticleComments { get; set; }
}
