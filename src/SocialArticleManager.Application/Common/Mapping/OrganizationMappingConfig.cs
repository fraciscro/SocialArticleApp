using Mapster;
using SocialArticleManager.Application.Organizations.Models;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Application.Common.Mapping
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
