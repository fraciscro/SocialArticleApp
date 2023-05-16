using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Common.Interfaces;

namespace SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Events
{
    public record ArticleCreated(Article Article,OrganizationId OrganizationId):IDomainEvent;
}
