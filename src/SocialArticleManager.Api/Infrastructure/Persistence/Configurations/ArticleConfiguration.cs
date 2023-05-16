using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;

namespace SocialArticleManager.Api.Infrastructure.Persistence.Configurations
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
