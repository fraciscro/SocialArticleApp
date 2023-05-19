
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.Events;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Common.Models;

namespace SocialArticleManager.Domain.Aggregates.ArticleAggregate
{
    public sealed class Article : Entity<ArticleId>
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public OrganizationId OrganizationId { get; private set; }
        private Article(string title, string content, OrganizationId organizationId)
        {
            Title = title;
            Content = content;
            OrganizationId = organizationId;

        }
        public static Article Create(string title, string content, OrganizationId organizationId)
        {
            var article = new Article(title, content, organizationId);
            article.AddDomainEvent(new ArticleCreated(article, organizationId));
            return article;

        }
        private Article()
        {

        }
    }
}
