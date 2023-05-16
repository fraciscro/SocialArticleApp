using MediatR;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Api.Application.Articles.Commands.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand>
    {
        private readonly IArticleRepository _articleRepository;
        public CreateArticleCommandHandler(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;            
        }
        public async Task Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article= Article.Create(request.Title, request.Content,OrganizationId.Create( Guid.Parse(request.OrganizationId)));
            await _articleRepository.AddAsync(article);
        }
    }
}
