using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Common.Interfaces;

namespace SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository
{
    public interface IOrganizationRepository:IBaseRepository<Organization,OrganizationId>
    {
    }
}
