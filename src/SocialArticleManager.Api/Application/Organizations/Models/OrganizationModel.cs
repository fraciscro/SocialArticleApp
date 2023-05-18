namespace SocialArticleManager.Api.Application.Organizations.Models
{
    public record OrganizationModel
    (
        string Id,
        string Name,
        string Url,
        OrganizationTypeModel OrganizationType
    );

     public enum OrganizationTypeModel
    {
        University,
        Department,
        ResearchCenter,
        ResearchGroup
    }
}
