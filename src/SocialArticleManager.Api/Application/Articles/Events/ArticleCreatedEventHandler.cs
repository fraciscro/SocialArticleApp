using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Events;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Articles.Events
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
