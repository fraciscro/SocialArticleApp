using MediatR;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Enums;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Application.Organizations.Commands.CreateOrganization
{
    public class CreateOrganizationTypeCommandHandler : IRequestHandler<CreateOrganizationCommand>
    {
        private readonly IOrganizationRepository _organizationRepository;
        public CreateOrganizationTypeCommandHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
            
        }
        public async Task Handle(CreateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = Organization.Create(request.Name, request.Url, request.OrganizationType);
            await _organizationRepository.AddAsync(organization);
        }
    }
}
