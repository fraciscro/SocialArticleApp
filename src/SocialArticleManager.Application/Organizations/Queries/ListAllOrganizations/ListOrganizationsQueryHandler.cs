using MapsterMapper;
using MediatR;
using SocialArticleManager.Application.Organizations.Models;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Application.Organizations.Queries.ListAllOrganizations
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
