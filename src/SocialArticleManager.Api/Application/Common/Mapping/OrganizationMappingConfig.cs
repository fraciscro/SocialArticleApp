using Mapster;
using SocialArticleManager.Api.Application.Organizations.Models;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Application.Common.Mapping
{
    public class OrganizationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Organization, OrganizationModel>()
           .Map(dest => dest.Id, src => src.Id.Value.ToString());
        }
    }
}
