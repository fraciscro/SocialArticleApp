using SocialArticleManager.Domain.Common.Models;

namespace SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository
{
    public sealed class OrganizationId : ValueObject
    {
        public Guid Value { get; private set; }
        private OrganizationId(Guid value)
        {
            Value = value;
        }
        public static OrganizationId Create(Guid Value)
        {
            return new OrganizationId(Value);
        }
        private OrganizationId()
        {

        }
    }
}
