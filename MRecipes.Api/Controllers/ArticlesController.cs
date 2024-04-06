using Microsoft.AspNetCore.Mvc;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Services;

namespace MRecipes.Api.Controllers;

[Route("/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly IArticleService _articleService;
    private readonly IArticleCommentService _articleCommentService;

    public ArticlesController(
        IArticleService articleService,
        IArticleCommentService articleCommentService
        )
    {
        _articleService = articleService;
        _articleCommentService = articleCommentService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleById(Guid id, CancellationToken cancellationToken)
    {
        var article = await _articleService.GetArticleByIdAsync(id, cancellationToken);

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
            ArticleComments = article.Comments.OrderByDescending(ac => ac.DateAdded).Select(c => new ArticleCommentDto { Id = c.Id, Name = c.Name, Description = c.Description, DateAdded = c.DateAdded }).ToList()
        };

        return Ok(dto);
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles(string searchTerm, string tags, CancellationToken cancellationToken)
    {
        var articles = await _articleService.GetArticlesAsync(searchTerm, tags, cancellationToken);

        return Ok(new ArticleResponse { Items = articles.Select(ToArticleDto).ToList() });
    }

    [HttpPost]
    public async Task<IActionResult> CreateArticle([FromBody] AddArticleDto dto, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(dto.Title) ||
           string.IsNullOrWhiteSpace(dto.Description) ||
           string.IsNullOrWhiteSpace(dto.Ingredients) ||
           string.IsNullOrWhiteSpace(dto.Tags) ||
           dto.Steps.Count <= 0
          )
        {
            return BadRequest("Fill all mandatory fields");
        }

        var result = await _articleService.CreateArticleAsync(dto, cancellationToken);

        return result != null ? Ok(result) : BadRequest();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateArticle([FromBody]UpdateArticleDto dto, CancellationToken cancellationToken)
    {
        if (Guid.Empty == dto.Id ||
            string.IsNullOrWhiteSpace(dto.Title) ||
           string.IsNullOrWhiteSpace(dto.Description) ||
           string.IsNullOrWhiteSpace(dto.Ingredients) ||
           string.IsNullOrWhiteSpace(dto.Tags) ||
           dto.Steps.Count <= 0
        )
        {
            return BadRequest("Fill all mandatory fields");
        }

        var result = await _articleService.UpdateArticleAsync(dto, cancellationToken);
        
        return result ? Ok() : BadRequest();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteArticle(Guid id, CancellationToken cancellationToken)
    {
        var result = await _articleService.DeleteArticleAsync(id, cancellationToken);

        return result ? NoContent() : BadRequest();
    }

    [HttpGet("tags")]
    public async Task<IActionResult> GetArticleTags(CancellationToken cancellationToken)
    {
        var tags = await _articleService.GetArticleTagsAsync(cancellationToken);

        return Ok(tags.Select(t => new TagDto { Name = t.Name }).ToList());
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateArticleComment([FromBody] ArticleCommentRequest request, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.CreateArticleCommentAsync(request, cancellationToken);

        return result ?  Ok() : BadRequest();
    }

    [HttpDelete("comment/{id}")]
    public async Task<IActionResult> DeleteArticleComment(Guid id, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.DeleteArticleCommentAsync(id, cancellationToken);

        return result ? NoContent() : BadRequest();
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
