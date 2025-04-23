using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MRecipes.Api.Models;

namespace MRecipes.Api.Persistence.Configurations;

public class ArticleImageConfiguration : IEntityTypeConfiguration<ArticleImage>
{
    public void Configure(EntityTypeBuilder<ArticleImage> builder)
    {
        builder.ToTable(nameof(ArticleImage));

        builder.HasKey(a => a.Id);

        builder.Property(x => x.ArticleId).IsRequired();
        builder.Property(x => x.Image).IsRequired();
    }
}
