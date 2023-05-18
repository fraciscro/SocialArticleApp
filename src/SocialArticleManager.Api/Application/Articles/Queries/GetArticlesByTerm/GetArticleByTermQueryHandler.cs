using MediatR;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Application.Common.Interfaces;

namespace SocialArticleManager.Api.Application.Articles.Queries.GetArticlesByTerm
{
    public class GetArticleByTermQueryHandler : IRequestHandler<GetArticlesByTermQuery, List<ArticleModel>>
    {
        private readonly IArticleElasticSearch _articleSearch;
        public GetArticleByTermQueryHandler(IArticleElasticSearch articleSearch)
        {
            _articleSearch = articleSearch;
        }
        public async Task<List<ArticleModel>> Handle(GetArticlesByTermQuery request, CancellationToken cancellationToken)
        {
            return await _articleSearch.SearchArticleByTerm(request.Term);
        }
    }
}
