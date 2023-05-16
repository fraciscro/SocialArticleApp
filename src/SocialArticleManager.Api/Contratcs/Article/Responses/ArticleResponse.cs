namespace SocialArticleManager.Api.Contratcs.Article.Responses
{
    public record ArticleResponse
    (
        string Id,
        string Title,
        string Content,
        string OrganizationId            
    );
}
