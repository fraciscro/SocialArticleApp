using SocialArticleManager.Api.Domain.Common.Models;

namespace SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects
{
    public sealed class OrganizationId:ValueObject
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
