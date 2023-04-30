using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Infrastructure.Persistence
{
    public class SocialArticleManagerContext:DbContext
    {
        public SocialArticleManagerContext(DbContextOptions<SocialArticleManagerContext> options):base(options)
        {

        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Organization> Articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SocialArticleManagerContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
