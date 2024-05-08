using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Contracts;
using MRecipes.Api.Models;
using MRecipes.Api.Persistence;

namespace MRecipes.Api.Services;

public interface IArticleService
{
    Task<Article?> GetArticleByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Article>> GetArticlesAsync(string searchTerm, string tags, CancellationToken cancellationToken);
    Task<Guid?> CreateArticleAsync(AddArticleDto dto, CancellationToken cancellationToken);
    Task<bool> UpdateArticleAsync(UpdateArticleDto dto, CancellationToken cancellationToken);
    Task<bool> DeleteArticleAsync(Guid id, CancellationToken cancellationToken);
    Task<List<Tag>> GetArticleTagsAsync(CancellationToken cancellationToken);
}

public class ArticleService : IArticleService
{
    private readonly MRecipesDbContext _dbContext;

    public ArticleService(MRecipesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Article?> GetArticleByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _dbContext.Articles
            .Include(a => a.Author)
            .Include(a => a.Tags).ThenInclude(t => t.Tag)
            .Include(a => a.Ingredients)
            .Include(a => a.Steps)
            .Include(a => a.Comments)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<Article>> GetArticlesAsync(string searchTerm, string tags, CancellationToken cancellationToken)
    {
        var articles = await _dbContext.Articles
          .Include(a => a.Author)
          .Include(a => a.Tags).ThenInclude(t => t.Tag)
          .OrderByDescending(a => a.DateAdded)
          .ToListAsync(cancellationToken);

        if (searchTerm != null && searchTerm != "")
        {
            articles = articles.Where(article => article.Title.Contains(searchTerm, StringComparison.CurrentCultureIgnoreCase)).ToList();
        }

        if (tags != null && tags.Length != 0)
        {
            var tagsArray = tags.Split(",").ToList();
            articles = articles.Where(article => tagsArray.All(tag => article.Tags.Any(articleTag => articleTag.Tag.Name.ToLower() == tag.Trim().ToLower()))).ToList();
        }

        return articles;
    }

    public async Task<Guid?> CreateArticleAsync(AddArticleDto dto, CancellationToken cancellationToken)
    {
        try
        {
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
                Steps = dto.Steps.Select(step => new Step { Name = step.Trim(), ArticleId = id }).ToList(),
                Ingredients = dto.Ingredients.Split(",").Select(ingredient => new Ingredient { ArticleId = id, Name = ingredient.Trim() }).ToList(),
                DateAdded = DateTime.Now,
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                Image = "",
                Tags = articleTags
            };

            // add article
            await _dbContext.Articles.AddAsync(newArticle, cancellationToken);

            // save changes
            await _dbContext.SaveChangesAsync(cancellationToken);

            return id;
        }
        catch(Exception)
        {
            return null;
        }
    }

    public async Task<bool> UpdateArticleAsync(UpdateArticleDto dto, CancellationToken cancellationToken)
    {
        try
        {
            var articleFromDb = await _dbContext.Articles
           .Include(a => a.Ingredients)
           .Include(a => a.Tags)
           .Include(a => a.Steps)
           .FirstOrDefaultAsync(a => a.Id == dto.Id);

            if (articleFromDb == null)
            {
                return false;
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
            articleFromDb.Steps = dto.Steps.Select(step => new Step { Name = step.Trim(), ArticleId = articleFromDb.Id }).ToList();
            articleFromDb.Ingredients = dto.Ingredients.Split(",").Select(ingredient => new Ingredient { ArticleId = articleFromDb.Id, Name = ingredient.Trim() }).ToList();
            articleFromDb.Tags = articleTags;

            _dbContext.SaveChanges();
            return true;
        }
        catch(Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteArticleAsync(Guid id, CancellationToken cancellationToken)
    {
        try
        {
            var articleToDelete = await _dbContext.Articles
            .Include(a => a.Tags)
            .Include(a => a.Steps)
            .Include(a => a.Ingredients)
            .Include(a => a.Comments)
            .FirstOrDefaultAsync(a => a.Id == id);

            if (articleToDelete == null)
            {
                return false;
            }

            _dbContext.Remove(articleToDelete);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<Tag>> GetArticleTagsAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Tags.ToListAsync(cancellationToken);
    }
}
