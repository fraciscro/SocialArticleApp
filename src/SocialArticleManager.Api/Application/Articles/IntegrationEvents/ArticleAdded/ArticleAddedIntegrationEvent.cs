using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Api.Application.Articles.IntegrationEvents.ArticleAdded
{
    public record ArticleAddedIntegrationEvent
        (
        Article Article
        ):INotification;
}
