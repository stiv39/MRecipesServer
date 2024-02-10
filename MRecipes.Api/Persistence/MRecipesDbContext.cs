using Microsoft.EntityFrameworkCore;
using MRecipes.Api.Models;

namespace MRecipes.Api.Persistence;

public class MRecipesDbContext : DbContext
{
    public MRecipesDbContext(DbContextOptions<MRecipesDbContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Article> Articles { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(MRecipesDbContext).Assembly);

        modelBuilder.Entity<Author>().HasData(
            new Author { Id = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"), Name = "Admin" }
            );

        modelBuilder.Entity<Tag>().HasData(
            new Tag { Id = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825"), Name = "Hlavny chod" },
            new Tag { Id = Guid.NewGuid(), Name = "Dezert" },
            new Tag { Id = Guid.NewGuid(), Name = "Predjedla" },
            new Tag { Id = Guid.NewGuid(), Name = "Salaty" },
            new Tag { Id = Guid.NewGuid(), Name = "Polievky" },
            new Tag { Id = Guid.NewGuid(), Name = "Napoje" },
            new Tag { Id = Guid.NewGuid(), Name = "Bez lepku" },
            new Tag { Id = Guid.NewGuid(), Name = "Bez laktozy" },
            new Tag { Id = Guid.NewGuid(), Name = "Sladke" }
            );

        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "sol" }
            );

        modelBuilder.Entity<Step>().HasData(
            new Step { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), Name = "Krok 1" }
            );

        modelBuilder.Entity<ArticleTag>().HasData(
            new ArticleTag { Id = Guid.NewGuid(), ArticleId = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"), TagId = Guid.Parse("8ee5d1b8-08e5-43e5-bdc9-28dc607e5825") }
            );

        modelBuilder.Entity<Article>().HasData(
            new Article
            {
                Id = Guid.Parse("a2c30491-5461-4e7f-b13d-d1d9d268206f"),
                AuthorId = Guid.Parse("f0b3d7e5-c3d6-4f91-914d-877c1b63c1f5"),
                DateAdded = DateTime.Now,
                Title = "Olivovy hummus",
                Description = "popis"
            }
            );

        base.OnModelCreating(modelBuilder);
    }
}
