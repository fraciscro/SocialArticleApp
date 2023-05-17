using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;

namespace SocialArticleManager.Api.Application.Articles.Queries.GetArticlesByTerm
{
    public record GetArticlesByTermQuery(string Term): IRequest<List<ArticleModel>>;
}
