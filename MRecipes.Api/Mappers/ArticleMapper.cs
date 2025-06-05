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
        return new TagDto { TagId = tag.Id, Name = tag.Name, HasImage = HasImage(tag.Id) };
    }

    private static bool HasImage(Guid id)
    {
        return id.ToString() switch
        {
            "8ee5d1b8-08e5-43e5-bdc9-28dc607e5825" or "a1f7fd4e-7c7a-4d5b-8a5c-56f5e2d4d18c" or "d1e13f16-9e32-4d3e-8302-28516d982aef" or "c1d698f0-1f87-4c30-9a31-c26e75d99c4f" or "b1eac43b-9a2a-4e37-94d2-0a59a493c7d3" => true,
            _ => false,
        };
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
