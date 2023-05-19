using SocialArticleManager.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Domain.Common.Interfaces;

namespace SocialArticleManager.Domain.Aggregates.ArticleAggregate.Repository
{
    public interface IArticleRepository : IBaseRepository<Article, ArticleId>
    {
    }
}
