using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MRecipes.Api.Mappers;

public interface IArticleMapper
{
    ArticleDetailsDto ToArticleDetailsDto(Article article);
    ArticleResponse ToArticleResponse(List<Article> articles);
    TagDto ToTagDto(Tag tag);
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
            Ingredients = article.Ingredients.Select(i => i.Name).ToList(),
            Tags = article.Tags.Select(i => i.Tag.Name).ToList(),
            Steps = article.Steps.Select(i => i.Name).ToList(),
            ArticleComments = article.Comments.OrderByDescending(ac => ac.DateAdded).Select(c => new ArticleCommentDto { Id = c.Id, Name = c.Name, Description = c.Description, DateAdded = c.DateAdded }).ToList()
        };
    }

    public ArticleResponse ToArticleResponse(List<Article> articles)
    {
        return new ArticleResponse { Items = articles.Select(ToArticleDto).ToList() };
    }

    public TagDto ToTagDto(Tag tag)
    {
        return new TagDto { Name = tag.Name };
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
            Tags = string.Join(",", article.Tags.Select(at => at.Tag.Name).ToList())
        };
    }
}
