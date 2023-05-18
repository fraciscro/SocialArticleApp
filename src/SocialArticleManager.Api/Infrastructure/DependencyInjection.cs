using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Nest;
using SocialArticleManager.Api.Application.Common.Interfaces;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Api.Infrastructure.ElasticSearch.Article;
using SocialArticleManager.Api.Infrastructure.Persistence;
using SocialArticleManager.Api.Infrastructure.Persistence.Interceptors;
using SocialArticleManager.Api.Infrastructure.Persistence.Repositories;
using System.Reflection;

namespace SocialArticleManager.Api.Infrastructure
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
