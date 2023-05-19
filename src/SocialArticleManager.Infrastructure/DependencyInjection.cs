using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialArticleManager.Application.Common.Interfaces;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Infrastructure.ElasticSearch.Article;
using SocialArticleManager.Infrastructure.Persistence;
using SocialArticleManager.Infrastructure.Persistence.Interceptors;
using SocialArticleManager.Infrastructure.Persistence.Repositories;
using System.Reflection;

namespace SocialArticleManager.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<SocialArticleManagerContext>(options =>
            options.UseSqlServer("Server=tcp:myappstest.database.windows.net,1433;Initial Catalog=SocialArticleManager;Persist Security Info=False;User ID=joel;Password=jJ963679933;MultipleActiveResultSets=False;Encrypt=True;"));
            services.AddScoped<PublishDomainEventsInterceptor>();
            services.AddScoped<IArticleElasticSearch, ArticleElasticSearch>();
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddAzureClients(builder =>
            {
                builder.AddSearchIndexClient(new
                    Uri("https://social-article-manager-search.search.windows.net"), new
                    AzureKeyCredential("YaUqbhZbsrF5CBszq8cKMkwGpiIqedMVKmxXdFoCB1AzSeB1MKD1"));
            });
            return services;
        }
    }
}
