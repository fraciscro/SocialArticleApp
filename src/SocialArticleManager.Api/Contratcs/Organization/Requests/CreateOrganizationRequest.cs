namespace SocialArticleManager.Api.Contratcs.Organization.Requests
{
    public record CreateOrganizationRequest
        (
        string Name,
        string Url,
        OrganizationTypeRequest organizationType
        );
    public enum OrganizationTypeRequest
    {
        University,
        Department,
        ResearchCenter,
        ResearchGroup
    }
}
