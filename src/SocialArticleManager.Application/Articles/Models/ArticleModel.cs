using System.ComponentModel.DataAnnotations;

namespace SocialArticleManager.Application.Articles.Models
{
    public record ArticleModel
    (
      
     string Id,
     string Title,
     string Content,
     Author Author
    );

    public record Author
    (
    string Name

    );
}
