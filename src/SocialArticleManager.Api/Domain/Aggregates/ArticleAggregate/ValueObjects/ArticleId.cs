using SocialArticleManager.Api.Domain.Common.Models;

namespace SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects
{
    public sealed class ArticleId:ValueObject
    {
        public int Value { get; private set; }
        private ArticleId(int value)
        {
            Value = value;
        }
        public static ArticleId Create(int value)
        {
            return new ArticleId(value);
        }
        private ArticleId()
        {

        }
    }
}
