using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Events;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Common.Models;

namespace SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate
{
    public sealed class Article:Entity<ArticleId>
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public OrganizationId OrganizationId { get; private set; }
        private Article(string title,string content, OrganizationId organizationId)
        {
            Title = title;
            Content = content;
            OrganizationId = organizationId;

        }
        public static Article Create(string title, string content, OrganizationId organizationId)
        {
           var article= new Article(title, content, organizationId);
           article.AddDomainEvent(new ArticleCreated(article,organizationId));
           return article;

        }
        private Article()
        {

        }
    }
}
