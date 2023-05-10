using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Enums;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Common.Models;

namespace SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate
{
    public sealed class Organization:Entity<OrganizationId>
    {
        private List<ArticleId> _articlesIds = new();
        public string Name { get; private set; }
        public string Url { get; private set; }
        public OrganizationType OrganizationType { get; set; }
        private Organization(string name, string url,OrganizationType organizationType)
        {
            Name = name;
            Url = url;
            OrganizationType = organizationType;

        }
        public static Organization Create(string name,string url, OrganizationType organizationType)
        {
            return new Organization(name,url, organizationType);
        }
        private Organization()
        {

        }
    }
}
