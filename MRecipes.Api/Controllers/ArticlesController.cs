using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;
using System.Threading;

namespace MRecipes.Api.Controllers;

[Route("/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly MRecipesDbContext _dbContext;

    public ArticlesController(MRecipesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleById(Guid id, CancellationToken token)
    {
        var article = await _dbContext.Articles
            .Include(a => a.Author)
            .Include(a => a.Tags).ThenInclude(t => t.Tag)
            .Include(a => a.Ingredients)
            .Include(a => a.Steps)
            .Include(a => a.Comments)
            .FirstOrDefaultAsync(x => x.Id == id, token);

        if (article == null)
        {
            return NotFound();
        }

        var dto = new ArticleDetailsDto
        {
            Id = article.Id,
            Title = article.Title,
            Description = article.Description,
            Image = article.Image,
            Author = article.Author.Name,
            DateAdded = article.DateAdded,
            Ingredients = article.Ingredients.Select(i => i.Name).ToList(),
            Tags = article.Tags.Select(i => i.Tag.Name).ToList(),
            Steps = article.Steps.Select(i => i.Name).ToList(),
            ArticleComments = article.Comments.Select(c => new ArticleCommentDto { Name = c.Name, Description = c.Description }).ToList()
        };

        return Ok(dto);
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles(string searchTerm, string tags, CancellationToken token)
    {
        var articles = await _dbContext.Articles
            .Include(a => a.Author)
            .Include(a => a.Tags).ThenInclude(t => t.Tag)
            .OrderByDescending(a => a.DateAdded)
            .ToListAsync(token);

        if (searchTerm != null && searchTerm != "")
        {
            articles = articles.Where(article => article.Title.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        if (tags != null && tags.Any())
        {
            var tagsArray = tags.Split(",").ToList();
            articles = articles.Where(article => tagsArray.All(tag => article.Tags.Any(articleTag => articleTag.Tag.Name.ToLower() == tag.Trim().ToLower()))).ToList();
        }

        return Ok(new ArticleResponse { Items = articles.Select(ToArticleDto).ToList() });
    }

    [HttpGet("tags")]
    public async Task<IActionResult> GetArticleTags(CancellationToken token)
    {
        var tags = await _dbContext.Tags.ToListAsync(token);

        return Ok(tags.Select(t => new TagDto { Name = t.Name }).ToList());
    }

    private ArticleDto ToArticleDto(Article article)
    {
        return new ArticleDto
        {
            Id = article.Id,
            Author = article.Author.Name,
            Title = article.Title,
            DateAdded = article.DateAdded,
            Image = article.Image,
            Tags = string.Join(",", article.Tags.Select(at => at.Tag.Name).ToList())
        };
    } 
}
