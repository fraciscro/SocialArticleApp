namespace SocialArticleManager.Api.Contratcs.Organization.Responses
{
    public record OrganizationResponse
    (
        string Id,
        string Name,
        string Url,
        OrganizationTypeResponse OrganizationType
    );

    public enum OrganizationTypeResponse
    {
        University,
        Department,
        ResearchCenter,
        ResearchGroup
    }
}
