using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Common.Interfaces;

namespace SocialArticleManager.Domain.Aggregates.ArticleAggregate.Events
{
    public record ArticleCreated(Article Article, OrganizationId OrganizationId) : IDomainEvent;
}
