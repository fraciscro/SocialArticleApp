namespace SocialArticleManager.Domain.Common.Models
{
    public abstract class Audit
    {
        public DateTime CreatedDate { get; protected set; }

        public Audit()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
