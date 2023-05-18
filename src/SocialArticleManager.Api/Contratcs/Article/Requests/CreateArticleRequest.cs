namespace SocialArticleManager.Api.Contratcs.Article.Requests
{
    public record CreateArticleRequest
    (
     string Title,
     string Content,
     string OrganizationId
     );
}
