using SocialArticleManager.Application.Articles.Models;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Application.Common.Interfaces
{
    public interface IArticleElasticSearch
    {
        Task AddArticle(ArticleModel article);
        Task<List<ArticleModel>> SearchArticleByTerm(string term);
    }
}
