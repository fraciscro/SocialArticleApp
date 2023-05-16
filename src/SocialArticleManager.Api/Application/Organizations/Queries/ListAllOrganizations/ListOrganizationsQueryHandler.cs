using MediatR;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Organizations.Queries.ListAllOrganizations
{
    public class ListOrganizationsQueryHandler : IRequestHandler<ListAllOrganizationsQuery, List<Organization>>
    {
        private readonly IOrganizationRepository _organizationRepository;
        public ListOrganizationsQueryHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
            
        }
        public async Task<List<Organization>> Handle(ListAllOrganizationsQuery request, CancellationToken cancellationToken)
        {
            return await _organizationRepository.GetAllAsync();
        }
    }
}
