using MRecipes.Api.Contracts;
using MRecipes.Api.Models;

namespace MRecipes.Api.Mappers;

public interface IArticleMapper
{
    ArticleDetailsDto ToArticleDetailsDto(Article article);
    ArticleResponse ToArticleResponse(List<Article> articles);
}

public class ArticleMapper : IArticleMapper
{
    public ArticleDetailsDto ToArticleDetailsDto(Article article)
    {
        return new ArticleDetailsDto
        {
            Id = article.Id,
            Title = article.Title,
            Description = article.Description,
            Image = article.Image == null ? null : Convert.ToBase64String(article.Image.Image),
            Author = article.Author.Name,
            DateAdded = article.DateAdded,
            Ingredients = [.. article.Ingredients.Select(i => i.Name)],
            Tags = [.. article.Tags.Select(i => i.Tag.Name)],
            Steps = [.. article.Steps.Select(i => i.Name)],
            ArticleComments = [.. article.Comments
                .OrderByDescending(ac => ac.DateAdded)
                .Select(c => new ArticleCommentDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    DateAdded = c.DateAdded
                })]
        };
    }

    public ArticleResponse ToArticleResponse(List<Article> articles)
    {
        return new ArticleResponse { Items = articles.Select(ToArticleDto).ToList() };
    }

    private ArticleDto ToArticleDto(Article article)
    {
        return new ArticleDto
        {
            Id = article.Id,
            Author = article.Author.Name,
            Title = article.Title,
            DateAdded = article.DateAdded,
            Image = article.Image == null ? null : Convert.ToBase64String(article.Image.Image),
            Tags = article.Tags.Select(at => at.Tag.Name).ToList()
        };
    }
}
