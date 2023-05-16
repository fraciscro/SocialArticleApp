using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Api.Infrastructure.Persistence;
using SocialArticleManager.Api.Infrastructure.Persistence.Interceptors;
using SocialArticleManager.Api.Infrastructure.Persistence.Repositories;
using System.Reflection;

namespace SocialArticleManager.Api.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<SocialArticleManagerContext>(options =>
            options.UseSqlServer("Server=tcp:myappstest.database.windows.net,1433;Initial Catalog=SocialArticleManager;Persist Security Info=False;User ID=joel;Password=jJ963679933;MultipleActiveResultSets=False;Encrypt=True;"));
            services.AddScoped<PublishDomainEventsInterceptor>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            return services;
        }
    }
}
