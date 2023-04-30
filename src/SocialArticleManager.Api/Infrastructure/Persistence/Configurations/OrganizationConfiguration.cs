using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Api.Infrastructure.Persistence.Configurations
{
    public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasConversion(o => o.Value,value=> OrganizationId.Create(value)).ValueGeneratedOnAdd();
            builder.Property(t => t.Id).HasDefaultValueSql("NEWID()");
            builder.Property(t => t.Name).IsRequired();
            builder.HasIndex(t => t.Name).IsUnique();
            builder.Property(t => t.Url).IsRequired();
            builder.HasIndex(t => t.Url).IsUnique();
        }
    }
}
