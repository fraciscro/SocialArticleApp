using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Common.Interfaces;
using SocialArticleManager.Api.Infrastructure.Persistence.Interceptors;

namespace SocialArticleManager.Api.Infrastructure.Persistence
{
    public class SocialArticleManagerContext:DbContext
    {
        private readonly PublishDomainEventsInterceptor _publishDomainEventsInterceptor;
        public SocialArticleManagerContext(DbContextOptions<SocialArticleManagerContext> options):base(options)
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
