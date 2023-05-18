using MapsterMapper;
using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.ValueObjects;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Api.Application.Articles.Queries.GetArticleById
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery,ArticleModel>
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;
        public GetArticleByIdQueryHandler(IArticleRepository articleRepository, IOrganizationRepository organizationRepository,IMapper mapper)
        {
            _articleRepository = articleRepository;
            _organizationRepository = organizationRepository;
            _mapper = mapper;
            
        }
        public async Task<ArticleModel> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var article = await _articleRepository.GetByIdAsync( ArticleId.Create(Guid.Parse(request.Id)));
            if(article is not null)
            {
                var organization= await _organizationRepository.GetByIdAsync(article.OrganizationId);  
                return _mapper.Map<ArticleModel>((article,organization));
            }
            throw new Exception("Not Found");
        }
    }
}
