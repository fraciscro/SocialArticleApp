using MediatR;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;

namespace SocialArticleManager.Application.Articles.IntegrationEvents.ArticleAdded
{
    public record ArticleAddedIntegrationEvent
        (
        Article Article
        ):INotification;
}
