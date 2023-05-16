using Mapster;
using SocialArticleManager.Api.Application.Articles.Commands.CreateArticle;
using SocialArticleManager.Api.Contratcs.Article.Requests;
using SocialArticleManager.Api.Contratcs.Article.Responses;
using SocialArticleManager.Api.Contratcs.Organization.Responses;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Common.Mapping
{
    public class ArticleMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Article, ArticleResponse>()
            .Map(dest => dest.Id, src => src.Id.Value.ToString());
            //config.NewConfig<CreateArticleRequest, CreateArticleCommand>()
            //.Map(dest => dest.OrganizationId, src => src.organizationId.Value.ToString());
        }
    }
}
