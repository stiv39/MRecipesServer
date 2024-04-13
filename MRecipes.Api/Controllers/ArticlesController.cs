using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRecipes.Api.Contracts;
using MRecipes.Api.Mappers;
using MRecipes.Api.Services;

namespace MRecipes.Api.Controllers;

[Route("/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly IArticleService _articleService;
    private readonly IArticleCommentService _articleCommentService;
    private readonly IArticleMapper _articleMapper;

    public ArticlesController(
        IArticleService articleService,
        IArticleCommentService articleCommentService
,
        IArticleMapper articleMapper)
    {
        _articleService = articleService;
        _articleCommentService = articleCommentService;
        _articleMapper = articleMapper;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetArticleById(Guid id, CancellationToken cancellationToken)
    {
        var article = await _articleService.GetArticleByIdAsync(id, cancellationToken);

        if (article == null)
        {
            return NotFound();
        }

        var dto = _articleMapper.ToArticleDetailsDto(article);

        return Ok(dto);
    }

    [HttpGet]
    public async Task<IActionResult> GetArticles(string searchTerm, string tags, CancellationToken cancellationToken)
    {
        var articles = await _articleService.GetArticlesAsync(searchTerm, tags, cancellationToken);

        return Ok(_articleMapper.ToArticleResponse(articles));
    }

    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Admin")]
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

        return Ok(tags.Select(_articleMapper.ToTagDto).ToList());
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateArticleComment([FromBody] ArticleCommentRequest request, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.CreateArticleCommentAsync(request, cancellationToken);

        return result ?  Ok() : BadRequest();
    }

    [Authorize(Roles = "Admin")]
    [HttpDelete("comment/{id}")]
    public async Task<IActionResult> DeleteArticleComment(Guid id, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.DeleteArticleCommentAsync(id, cancellationToken);

        return result ? NoContent() : BadRequest();
    }
}
