using MapsterMapper;
using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Api.Infrastructure.Persistence.Repositories;

namespace SocialArticleManager.Api.Application.Articles.Queries.ListAllArticles
{
    public class ListAllArticlesQueryHandler : IRequestHandler<ListAllArticlesQuery, List<ArticleModel>>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public ListAllArticlesQueryHandler(IArticleRepository articleRepository, IOrganizationRepository organizationRepository,IMapper mapper)
        {
            _articleRepository = articleRepository;
            _organizationRepository = organizationRepository;
            _mapper = mapper;
                
        }
        public async Task<List<ArticleModel>> Handle(ListAllArticlesQuery request, CancellationToken cancellationToken)
        {
            var currentArticles = await _articleRepository.GetAllAsync();
            var organizations = await _organizationRepository.GetByIdsAsync(currentArticles.Select(a=>a.OrganizationId).ToList());
            var articles= new List<ArticleModel>();
            foreach (var article in currentArticles)
            {
                var organization = organizations.Where(o => o.Id.Value == article.OrganizationId.Value).FirstOrDefault();
                var currentArticle =_mapper.Map<ArticleModel>((article,organization));
                articles.Add(currentArticle);
            }
            return articles;
        }
    }
}
