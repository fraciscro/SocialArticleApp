using MediatR;
using SocialArticleManager.Api.Application.Organizations.Models;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Application.Organizations.Queries.ListAllOrganizations
{
    public record ListAllOrganizationsQuery():IRequest<List<OrganizationModel>>;
}
