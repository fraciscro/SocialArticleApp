using MediatR;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.Events;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Application.Articles.Events
{
    public class ArticleCreatedEventHandler : INotificationHandler<ArticleCreated>
    {
        private readonly IOrganizationRepository _organizationRepository;
        public ArticleCreatedEventHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
            
        }
        public async Task Handle(ArticleCreated notification, CancellationToken cancellationToken)
        {

            var organization = await _organizationRepository.GetByIdAsync(notification.OrganizationId);
            if(organization == null)
            {
                throw new ArgumentException("This organization doesn't exist");
            }
           

        }
    }
}
