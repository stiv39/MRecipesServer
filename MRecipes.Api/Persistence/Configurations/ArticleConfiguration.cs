using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRecipes.Api.Models;

namespace MRecipes.Api.Persistence.Configurations;

public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.ToTable(nameof(Article));

        builder.HasKey(a => a.Id);

        builder.HasMany(a => a.Ingredients)
            .WithOne(i => i.Article)
            .HasForeignKey(i => i.ArticleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.Steps)
            .WithOne(s => s.Article)
            .HasForeignKey(s => s.ArticleId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.Comments)
            .WithOne(ac => ac.Article)
            .HasForeignKey(ac => ac.ArticleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
