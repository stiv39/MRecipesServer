namespace MRecipes.Api.Contracts;

public class ArticleResponse
{
    public List<ArticleDto> Items { get; set; } = new List<ArticleDto>();
}
