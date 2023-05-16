using SocialArticleManager.Api.Domain.Common.Models;

namespace SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects
{
    public sealed class ArticleId:ValueObject
    {
        public Guid Value { get; private set; }
        private ArticleId(Guid value)
        {
            Value = value;
        }
        public static ArticleId Create(Guid value)
        {
            return new ArticleId(value);
        }
        private ArticleId()
        {

        }
    }
}
