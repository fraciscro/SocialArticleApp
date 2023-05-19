using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Domain.Common.Interfaces;
using SocialArticleManager.Infrastructure.Persistence.Interceptors;

namespace SocialArticleManager.Infrastructure.Persistence
{
    public class SocialArticleManagerContext : DbContext
    {
        private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;
        public SocialArticleManagerContext(DbContextOptions<SocialArticleManagerContext> options) : base(options)
        {

        }
        public SocialArticleManagerContext(DbContextOptions<SocialArticleManagerContext> options, PublishDomainEventsInterceptor publishDomainEventsInterceptor) : base(options)
        {
            _publishDomainEventsInterceptor = publishDomainEventsInterceptor;

        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Article> Articles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<List<IDomainEvent>>().
                ApplyConfigurationsFromAssembly(typeof(SocialArticleManagerContext).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SocialArticleManagerContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
