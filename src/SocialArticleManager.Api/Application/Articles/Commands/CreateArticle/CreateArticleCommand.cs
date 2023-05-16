using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Api.Application.Articles.Commands.CreateArticle
{
    public record CreateArticleCommand
        (
         string Title,
         string Content,
         string OrganizationId        
        ):IRequest;
}
