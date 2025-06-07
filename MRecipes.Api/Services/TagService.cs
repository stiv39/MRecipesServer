using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;

namespace MRecipes.Api.Services;

public interface ITagService
{
    Task<List<Tag>> GetTagsAsync(CancellationToken cancellationToken);
    Task CreateNewTagAsync(TagDto tagDto, CancellationToken cancellationToken);
    Task UpdateTagAsync(TagDto tagDto, CancellationToken cancellationToken);
    Task DeleteTagAsync(Guid id, CancellationToken cancellationToken);
}

public class TagService : ITagService
{
    private readonly MRecipesDbContext _dbContext;

    public TagService(MRecipesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<List<Tag>> GetTagsAsync(CancellationToken cancellationToken) => _dbContext.Tags.ToListAsync(cancellationToken);

    public async Task CreateNewTagAsync(TagDto tagDto, CancellationToken cancellationToken)
    {
        var tagToCreate = new Tag
        {
            Name = tagDto.Name,
            Id = Guid.NewGuid()
        };

        _dbContext.Tags.Add(tagToCreate);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateTagAsync(TagDto tagDto, CancellationToken cancellationToken)
    {
        var tagFromDb = await _dbContext.Tags.SingleOrDefaultAsync(x => x.Id == tagDto.TagId, cancellationToken);

        if (tagFromDb == null)
        {
            throw new InvalidOperationException($"Tag with id {tagDto.TagId} does not exist");
        }

        tagFromDb.Name = tagDto.Name;

        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteTagAsync(Guid id, CancellationToken cancellationToken)
    {
        var tagFromDb = await _dbContext.Tags.SingleOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (tagFromDb == null)
        {
            throw new InvalidOperationException($"Tag with id {id} does not exist");
        }

        _dbContext.Remove(tagFromDb);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
