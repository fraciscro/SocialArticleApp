using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Api.Application.Common.Interfaces
{
    public interface IArticleElasticSearch
    {
        Task AddArticle(ArticleModel article);
        Task<List<ArticleModel>> SearchArticleByTerm(string term);
    }
}
