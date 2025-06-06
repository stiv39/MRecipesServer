namespace MRecipes.Api.Contracts;

public class ArticleDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime DateAdded { get; set; }
    public string Author { get; set; } = string.Empty;
    public List<string> Tags {  get; set; } = [];
    public string Image { get; set; } = string.Empty;
}
