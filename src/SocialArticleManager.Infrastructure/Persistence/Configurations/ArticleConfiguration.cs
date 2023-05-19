using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Infrastructure.Persistence.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasConversion(o => o.Value, value => ArticleId.Create(value)).ValueGeneratedOnAdd();
            builder.Property(a => a.Id).HasDefaultValueSql("NEWID()");
            builder.Property(a => a.OrganizationId).HasConversion(o => o.Value, value => OrganizationId.Create(value));
        }

    }
}
