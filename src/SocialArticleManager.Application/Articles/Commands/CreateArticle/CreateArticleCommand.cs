using MediatR;

namespace SocialArticleManager.Application.Articles.Commands.CreateArticle
{
    public record CreateArticleCommand
        (
         string Title,
         string Content,
         string OrganizationId        
        ):IRequest;
}
