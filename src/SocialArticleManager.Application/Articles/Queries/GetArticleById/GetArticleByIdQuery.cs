using MediatR;
using SocialArticleManager.Application.Articles.Models;

namespace SocialArticleManager.Application.Articles.Queries.GetArticleById
{
    public record GetArticleByIdQuery(string Id):IRequest<ArticleModel>;
}
