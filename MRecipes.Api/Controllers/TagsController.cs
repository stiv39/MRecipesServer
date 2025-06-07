using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MRecipes.Api.Contracts;
using MRecipes.Api.Identity;
using MRecipes.Api.Mappers;
using MRecipes.Api.Services;
using System.Security.Claims;

namespace MRecipes.Api.Controllers;


[Route("/[controller]")]
public class TagsController : ControllerBase
{
    private readonly ITagService _tagService;
    private readonly ITagMapper _tagMapper;

    public TagsController(ITagService tagService, ITagMapper tagMapper)
    {
        _tagService = tagService;
        _tagMapper = tagMapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetTags(CancellationToken cancellationToken)
    {
        var tags = await _tagService.GetTagsAsync(cancellationToken);

        return Ok(tags.Select(_tagMapper.ToDto).ToList());
    }

    [Authorize]
    [RequiresClaim(ClaimTypes.Role, "Admin")]
    [HttpPost]
    public async Task<IActionResult> CreateTag(TagDto tagDto, CancellationToken cancellationToken)
    {
        await _tagService.CreateNewTagAsync(tagDto, cancellationToken);
        return Ok();
    }

    [Authorize]
    [RequiresClaim(ClaimTypes.Role, "Admin")]
    [HttpPut]
    public async Task<IActionResult> UpdateTag(TagDto tagDto, CancellationToken cancellationToken)
    {
        await _tagService.UpdateTagAsync(tagDto, cancellationToken);
        return Ok();
    }

    [Authorize]
    [RequiresClaim(ClaimTypes.Role, "Admin")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTag(Guid id, CancellationToken cancellationToken)
    {
        await _tagService.DeleteTagAsync(id, cancellationToken);
        return Ok();
    }
}
