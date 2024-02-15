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
            ArticleComments = article.Comments.OrderByDescending(ac => ac.DateAdded).Select(c => new ArticleCommentDto { Name = c.Name, Description = c.Description, DateAdded = c.DateAdded }).ToList()
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

    [HttpPost]
    public async Task<IActionResult> CreateArticle(AddArticleDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Title) ||
           string.IsNullOrWhiteSpace(dto.Description) ||
           string.IsNullOrWhiteSpace(dto.Ingredients) ||
           string.IsNullOrWhiteSpace(dto.Steps) ||
           string.IsNullOrWhiteSpace(dto.Tags)
          )
        {
            return BadRequest("Fill all mandatory fields");
        }

        // Create new id for new article
        var id = Guid.NewGuid();

        var articleTags = new List<ArticleTag>();

        var dbTags = await _dbContext.Tags.ToListAsync();

        foreach (var dtoTag in dto.Tags.Split(","))
        {
            var tag = dbTags.FirstOrDefault(t => t.Name.ToLower() == dtoTag.Trim().ToLower());
            if (tag != null)
            {
                articleTags.Add(new ArticleTag { ArticleId = id, TagId = tag.Id });
            }
        }

        // map dto to article
        var newArticle = new Article
        {
            Id = id,
            Title = dto.Title,
            Description = dto.Description,
            Steps = dto.Steps.Split(",").Select(step => new Step { Name = step.Trim(), ArticleId = id }).ToList(),
            Ingredients = dto.Ingredients.Split(",").Select(ingredient => new Ingredient { ArticleId = id, Name = ingredient.Trim() }).ToList(),
            DateAdded = DateTime.Now,
            AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
            Image = "",
            Tags = articleTags
        };

        // add article
        await _dbContext.Articles.AddAsync(newArticle);

        // save changes
        await _dbContext.SaveChangesAsync();

        return Ok(id);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateArticle(UpdateArticleDto dto)
    {
        if (Guid.Empty == dto.ArticleId ||
            string.IsNullOrWhiteSpace(dto.Title) ||
           string.IsNullOrWhiteSpace(dto.Description) ||
           string.IsNullOrWhiteSpace(dto.Ingredients) ||
           string.IsNullOrWhiteSpace(dto.Steps) ||
           string.IsNullOrWhiteSpace(dto.Tags)
        )
        {
            return BadRequest("Fill all mandatory fields");
        }

        var articleFromDb = await _dbContext.Articles
            .Include(a => a.Ingredients)
            .Include(a => a.Tags)
            .Include(a => a.Steps)
            .FirstOrDefaultAsync(a => a.Id == dto.ArticleId);

        if (articleFromDb == null)
        {
            return NotFound();
        }

        var articleTags = new List<ArticleTag>();

        var dbTags = await _dbContext.Tags.ToListAsync();

        foreach (var dtoTag in dto.Tags.Split(","))
        {
            var tag = dbTags.FirstOrDefault(t => t.Name.ToLower() == dtoTag.Trim().ToLower());
            if (tag != null)
            {
                articleTags.Add(new ArticleTag { ArticleId = articleFromDb.Id, TagId = tag.Id });
            }
        }

        articleFromDb.Title = dto.Title;
        articleFromDb.Description = dto.Description;
        articleFromDb.Steps = dto.Steps.Split(",").Select(step => new Step { Name = step.Trim(), ArticleId = articleFromDb.Id }).ToList();
        articleFromDb.Ingredients = dto.Ingredients.Split(",").Select(ingredient => new Ingredient { ArticleId = articleFromDb.Id, Name = ingredient.Trim() }).ToList();
        articleFromDb.Tags = articleTags;

        _dbContext.SaveChanges();
        
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteArticle(Guid id)
    {
        var articleToDelete = await _dbContext.Articles
            .Include(a => a.Tags)
            .Include(a => a.Steps)
            .Include(a => a.Ingredients)
            .Include(a => a.Comments)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (articleToDelete == null)
        {
            return NotFound();
        }

        _dbContext.Remove(articleToDelete);

        await _dbContext.SaveChangesAsync();

        return NoContent();
    }

    [HttpGet("tags")]
    public async Task<IActionResult> GetArticleTags(CancellationToken token)
    {
        var tags = await _dbContext.Tags.ToListAsync(token);

        return Ok(tags.Select(t => new TagDto { Name = t.Name }).ToList());
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateArticleComment([FromBody] ArticleCommentRequest request)
    {
        var article = await _dbContext.Articles.FirstOrDefaultAsync(a => a.Id == request.ArticleId);

        if (article == null || string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Description))
        {
            return BadRequest();
        }

        await _dbContext.ArticleComments.AddAsync(new ArticleComment { ArticleId = request.ArticleId, Name = request.Name, Description = request.Description, DateAdded = DateTime.Now });
        await _dbContext.SaveChangesAsync();

        return Ok();
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
