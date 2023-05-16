using Mapster;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Common.Mapping
{
    public class OrganizationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Organization, OrganizationResponse>()
           .Map(dest => dest.Id, src => src.Id.Value.ToString());
        }
    }
}
