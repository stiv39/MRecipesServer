using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;

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
    public async Task<IActionResult> GetArticleById(Guid id)
    {
        var article = await _dbContext.Articles
            .Include(a => a.Author)
            .Include(a => a.Tags).ThenInclude(t => t.Tag)
            .Include(a => a.Ingredients)
            .Include(a => a.Steps)
            .FirstOrDefaultAsync(x => x.Id == id);

        if(article == null)
        {
            return NotFound();
        }

        var dto = new ArticleDetailsDto
        {
            Id = article.Id,
            Title = article.Title,
            Description = article.Description,
            Author = article.Author.Name,
            DateAdded = article.DateAdded,
            Ingredients = article.Ingredients.Select(i => i.Name).ToList(),
            Tags = article.Tags.Select(i => i.Tag.Name).ToList(),
            Steps = article.Steps.Select(i => i.Name).ToList()
        };

        return Ok(dto);
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles(string searchTerm, List<string> tags)
    {
        var articles = await _dbContext.Articles.ToListAsync();

        if (searchTerm != null && searchTerm != "")
        {
            articles = articles.Where(article => article.Title.ToLower().Contains(searchTerm.ToLower())).ToList();
        }

        if (tags != null && tags.Any())
        {
            // TO DO
        }    

        return Ok(articles);
    }
}
