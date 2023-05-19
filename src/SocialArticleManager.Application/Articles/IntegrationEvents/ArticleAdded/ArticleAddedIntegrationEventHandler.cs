using MapsterMapper;
using MediatR;
using SocialArticleManager.Application.Articles.Models;
using SocialArticleManager.Application.Common.Interfaces;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Application.Articles.IntegrationEvents.ArticleAdded
{
    public class ArticleAddedIntegrationEventHandler : INotificationHandler<ArticleAddedIntegrationEvent>
    {
        private readonly IArticleElasticSearch _articleElasticSearch;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public ArticleAddedIntegrationEventHandler(IArticleElasticSearch articleElasticSearch,IOrganizationRepository organizationRepository,IMapper mapper)
        {
            _articleElasticSearch = articleElasticSearch;
            _organizationRepository = organizationRepository;
            _mapper = mapper;
        }
        public async Task Handle(ArticleAddedIntegrationEvent notification, CancellationToken cancellationToken)
        {
            var organization = await _organizationRepository.GetByIdAsync(notification.Article.OrganizationId);
            var article = _mapper.Map<ArticleModel>((notification.Article, organization));
            await _articleElasticSearch.AddArticle(article);
        }
    }
}
