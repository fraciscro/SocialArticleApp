using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Enums;

namespace SocialArticleManager.Api.Application.Organizations.Commands.CreateOrganization
{
    public record CreateOrganizationCommand(
        string Name,
        string Url,
        OrganizationType OrganizationType
        ) : IRequest;
        

}


