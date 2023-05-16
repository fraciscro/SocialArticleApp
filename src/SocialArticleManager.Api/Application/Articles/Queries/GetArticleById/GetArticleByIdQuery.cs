using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;

namespace SocialArticleManager.Api.Application.Articles.Queries.GetArticleById
{
    public record GetArticleByIdQuery(string Id):IRequest<ArticleModel>;
}
