using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRecipes.Api.Models;

namespace MRecipes.Api.Persistence.Configurations;

public class ArticleTagConfiguration : IEntityTypeConfiguration<ArticleTag>
{
    public void Configure(EntityTypeBuilder<ArticleTag> builder)
    {
        builder.ToTable(nameof(ArticleTag));
        builder.HasKey(x => x.Id);

        builder.HasOne(at => at.Article)
            .WithMany(a => a.Tags)
            .HasForeignKey(a => a.ArticleId);

        builder.HasOne(at => at.Tag)
            .WithMany()
            .HasForeignKey(at => at.TagId);
    }
}
