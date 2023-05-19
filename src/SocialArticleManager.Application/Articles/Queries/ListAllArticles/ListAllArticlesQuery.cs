using MediatR;
using SocialArticleManager.Application.Articles.Models;

namespace SocialArticleManager.Application.Articles.Queries.ListAllArticles
{
    public record ListAllArticlesQuery():IRequest<List<ArticleModel>>;
}
