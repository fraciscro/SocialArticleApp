using MediatR;
using SocialArticleManager.Application.Articles.Models;

namespace SocialArticleManager.Application.Articles.Queries.GetArticlesByTerm
{
    public record GetArticlesByTermQuery(string Term): IRequest<List<ArticleModel>>;
}
