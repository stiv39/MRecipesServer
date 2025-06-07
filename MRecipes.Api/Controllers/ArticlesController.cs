using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRecipes.Api.Contracts;
using MRecipes.Api.Identity;
using MRecipes.Api.Mappers;
using MRecipes.Api.Services;
using System.Security.Claims;
using System.Text.Json;

namespace MRecipes.Api.Controllers;

[Route("/[controller]")]
public class ArticlesController : ControllerBase
{
    private readonly IArticleService _articleService;
    private readonly IArticleCommentService _articleCommentService;
    private readonly IArticleMapper _articleMapper;

    public ArticlesController(
        IArticleService articleService,
        IArticleCommentService articleCommentService,
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

    [Authorize]
    [RequiresClaim(ClaimTypes.Role, "Admin")]
    [HttpPost]
    public async Task<IActionResult> CreateArticle([FromForm] IFormFile image, [FromForm] string dto, CancellationToken cancellationToken)
    {
        var dtoParsed = JsonSerializer.Deserialize<AddArticleDto>(dto);
        if (dtoParsed == null ||
           string.IsNullOrWhiteSpace(dtoParsed.Title) ||
           string.IsNullOrWhiteSpace(dtoParsed.Description) ||
           string.IsNullOrWhiteSpace(dtoParsed.Ingredients) ||
           dtoParsed.Tags.Count <= 0 ||
           dtoParsed.Steps.Count <= 0
          )
        {
            return BadRequest("Fill all mandatory fields");
        }

        var result = await _articleService.CreateArticleAsync(dtoParsed, image, cancellationToken);

        return result != null ? Ok(result) : BadRequest();
    }

    [Authorize(Policy = IdentityData.RoleUserPolicyName)]
    [HttpPut]
    public async Task<IActionResult> UpdateArticle([FromForm] IFormFile image, [FromForm] string dto, CancellationToken cancellationToken)
    {
        var dtoParsed = JsonSerializer.Deserialize<UpdateArticleDto>(dto);
        if (dtoParsed == null || Guid.Empty == dtoParsed.Id ||
            string.IsNullOrWhiteSpace(dtoParsed.Title) ||
           string.IsNullOrWhiteSpace(dtoParsed.Description) ||
           string.IsNullOrWhiteSpace(dtoParsed.Ingredients) ||
           dtoParsed.Tags.Count <= 0 ||
           dtoParsed.Steps.Count <= 0
        )
        {
            return BadRequest("Fill all mandatory fields");
        }

        var result = await _articleService.UpdateArticleAsync(dtoParsed, image, cancellationToken);

        return result ? Ok() : BadRequest();
    }

    [Authorize(Policy = IdentityData.RoleUserPolicyName)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteArticle(Guid id, CancellationToken cancellationToken)
    {
        var result = await _articleService.DeleteArticleAsync(id, cancellationToken);

        return result ? NoContent() : BadRequest();
    }

    [HttpPost("comment")]
    public async Task<IActionResult> CreateArticleComment([FromBody] ArticleCommentRequest request, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.CreateArticleCommentAsync(request, cancellationToken);

        return result ? Ok() : BadRequest();
    }

    [Authorize(Policy = IdentityData.RoleUserPolicyName)]
    [HttpDelete("comment/{id}")]
    public async Task<IActionResult> DeleteArticleComment(Guid id, CancellationToken cancellationToken)
    {
        var result = await _articleCommentService.DeleteArticleCommentAsync(id, cancellationToken);

        return result ? NoContent() : BadRequest();
    }
}
