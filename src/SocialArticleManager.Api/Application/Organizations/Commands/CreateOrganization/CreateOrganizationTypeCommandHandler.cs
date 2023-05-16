using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Enums;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Organizations.Commands.CreateOrganization
{
    public class CreateOrganizationTypeCommandHandler : IRequestHandler<CreateOrganizationCommand, Organization>
    {
        private readonly IOrganizationRepository _organizationRepository;
        public CreateOrganizationTypeCommandHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
            
        }
        public async Task<Organization> Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = Organization.Create(request.Name, request.Url, request.OrganizationType);
            await _organizationRepository.AddAsync(organization);
            return organization;
        }
    }
}
