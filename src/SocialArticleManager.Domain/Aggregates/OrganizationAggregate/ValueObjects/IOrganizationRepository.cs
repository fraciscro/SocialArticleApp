using SocialArticleManager.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Common.Interfaces;

namespace SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects
{
    public interface IOrganizationRepository : IBaseRepository<Organization, OrganizationId>
    {
    }
}
