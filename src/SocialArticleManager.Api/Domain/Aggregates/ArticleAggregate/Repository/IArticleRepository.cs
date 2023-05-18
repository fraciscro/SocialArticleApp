using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Common.Interfaces;

namespace SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository
{
    public interface IArticleRepository:IBaseRepository<Article,ArticleId>
    {
    }
}
