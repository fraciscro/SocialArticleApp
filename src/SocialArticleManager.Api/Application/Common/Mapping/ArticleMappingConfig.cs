using Mapster;
using SocialArticleManager.Api.Application.Articles.Models;
using SocialArticleManager.Api.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;

namespace SocialArticleManager.Api.Application.Common.Mapping
{
    public class ArticleMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<(Article Article, Organization Organization), ArticleModel>()
             .Map(dest => dest.Id, src => src.Article.Id.Value.ToString())
             .Map(dest => dest.Title, src => src.Article.Title)
             .Map(dest => dest.Content, src => src.Article.Content)
             .Map(dest => dest.Author, src => src.Organization);
            config.NewConfig< Organization ,Author>().Map(dest => dest.Name, src => src.Name);
            //config.NewConfig<CreateArticleRequest, CreateArticleCommand>()
            //.Map(dest => dest.OrganizationId, src => src.organizationId.Value.ToString());
        }
    }
}
