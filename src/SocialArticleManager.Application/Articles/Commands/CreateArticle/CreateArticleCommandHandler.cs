using MediatR;
using SocialArticleManager.Application.Articles.IntegrationEvents.ArticleAdded;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.OrganizationAggregate.Repository;

namespace SocialArticleManager.Application.Articles.Commands.CreateArticle
{
    public class CreateArticleCommandHandler : IRequestHandler<CreateArticleCommand>
    {
        private readonly IMediator _mediator;
        private readonly IArticleRepository _articleRepository;
        public CreateArticleCommandHandler(IArticleRepository articleRepository, IMediator mediator)
        {
            _articleRepository = articleRepository;
            _mediator = mediator;
        }
        public async Task Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article= Article.Create(request.Title, request.Content,OrganizationId.Create( Guid.Parse(request.OrganizationId)));
            await _articleRepository.AddAsync(article);
            await _mediator.Publish(new ArticleAddedIntegrationEvent(article));
        }
    }
}
