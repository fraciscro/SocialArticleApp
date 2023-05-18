using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Application.Articles.IntegrationEvents.ArticleAdded;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;
using System.Reflection;

namespace SocialArticleManager.Api.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.GetExecutingAssembly());

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            return services;
        }
    }
}
