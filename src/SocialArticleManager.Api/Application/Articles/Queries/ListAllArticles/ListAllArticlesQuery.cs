using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;

namespace SocialArticleManager.Api.Application.Articles.Queries.ListAllArticles
{
    public record ListAllArticlesQuery():IRequest<List<ArticleModel>>;
}
