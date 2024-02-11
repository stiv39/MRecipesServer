namespace MRecipes.Api.Models;

public class Article
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Image {  get; set; } = string.Empty;
    public Guid AuthorId { get; set; }
    public Author Author { get; set; }
    public DateTime DateAdded { get; set; }
    public ICollection<Step> Steps { get; set; }
    public ICollection<ArticleTag> Tags { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public ICollection<ArticleComment> Comments { get; set; }
}
