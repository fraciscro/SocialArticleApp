using MediatR;
using SocialArticleManager.Api.Application.Articles.Queries.Models;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Articles.Queries.GetArticleById
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery,ArticleModel>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IOrganizationRepository _organizationRepository;
        public GetArticleByIdQueryHandler(IArticleRepository articleRepository, IOrganizationRepository organizationRepository)
        {
            _articleRepository = articleRepository;
            _organizationRepository = organizationRepository;
            
        }
        public async Task<ArticleModel> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var article = await _articleRepository.GetByIdAsync( ArticleId.Create(Guid.Parse(request.Id)));
            if(article is not null)
            {
                var organization= await _organizationRepository.GetByIdAsync(article.OrganizationId);
                var currentArticle= new ArticleModel(article.Id.Value.ToString(),article.Title,article.Content,new Author(organization.Name));
                return currentArticle;
            }
            throw new Exception("Not Found");
        }
    }
}
