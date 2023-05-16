using MapsterMapper;
using MediatR;
using SocialArticleManager.Api.Application.Organizations.Models;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Organizations.Queries.ListAllOrganizations
{
    public class ListOrganizationsQueryHandler : IRequestHandler<ListAllOrganizationsQuery, List<OrganizationModel>>
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public ListOrganizationsQueryHandler(IOrganizationRepository organizationRepository,IMapper mapper)
        {
            _organizationRepository = organizationRepository;
            _mapper = mapper;
            
        }
        public async Task<List<OrganizationModel>> Handle(ListAllOrganizationsQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<OrganizationModel>>(await _organizationRepository.GetAllAsync());
        }
    }
}
