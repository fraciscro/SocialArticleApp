using MediatR;
using SocialArticleManager.Application.Organizations.Models;

namespace SocialArticleManager.Application.Organizations.Queries.ListAllOrganizations
{
    public record ListAllOrganizationsQuery():IRequest<List<OrganizationModel>>;
}
