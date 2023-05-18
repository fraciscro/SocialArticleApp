using MapsterMapper;
using MediatR;
using Nest;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Application.Common.Interfaces;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Articles.IntegrationEvents.ArticleAdded
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
