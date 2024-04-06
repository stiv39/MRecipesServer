using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;

namespace MRecipes.Api.Services;

public interface IArticleCommentService
{
    Task<bool> CreateArticleCommentAsync(ArticleCommentRequest request, CancellationToken cancellationToken);
    Task<bool> DeleteArticleCommentAsync(Guid id, CancellationToken cancellationToken);
}

public class ArticleCommentService : IArticleCommentService
{
    private readonly MRecipesDbContext _dbContext;

    public ArticleCommentService(MRecipesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> CreateArticleCommentAsync(ArticleCommentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var article = await _dbContext.Articles.FirstOrDefaultAsync(a => a.Id == request.ArticleId, cancellationToken: cancellationToken);

            if (article == null || string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Description))
            {
                return false;
            }

            await _dbContext.ArticleComments.AddAsync(new ArticleComment { ArticleId = request.ArticleId, Name = request.Name, Description = request.Description, DateAdded = DateTime.Now }, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteArticleCommentAsync(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var comment = await _dbContext.ArticleComments.FirstOrDefaultAsync(c => c.Id == id);

            if (comment == null)
            {
                return false;
            }

            _dbContext.Remove(comment);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch(Exception)
        {
            return false;
        }
    }
}
