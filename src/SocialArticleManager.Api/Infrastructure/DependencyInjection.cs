using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Infrastructure.Persistence;
using System.Reflection;

namespace SocialArticleManager.Api.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<SocialArticleManagerContext>(options =>
          options.UseSqlServer("Server=tcp:myappstest.database.windows.net,1433;Initial Catalog=SocialArticleManager;Persist Security Info=False;User ID=joel;Password=jJ963679933;MultipleActiveResultSets=False;Encrypt=True;"));
            return services;
        }
    }
}
