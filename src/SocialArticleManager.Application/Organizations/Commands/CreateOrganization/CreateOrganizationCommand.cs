using MediatR;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Enums;

namespace SocialArticleManager.Application.Organizations.Commands.CreateOrganization
{
    public record CreateOrganizationCommand(
        string Name,
        string Url,
        OrganizationType OrganizationType
        ) : IRequest;
        

}


