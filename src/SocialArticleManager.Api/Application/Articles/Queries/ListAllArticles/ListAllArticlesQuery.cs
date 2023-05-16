using MediatR;
using SocialArticleManager.Api.Application.Articles.Queries.Models;

namespace SocialArticleManager.Api.Application.Articles.Queries.ListAllArticles
{
    public record ListAllArticlesQuery():IRequest<List<ArticleModel>>;
}
