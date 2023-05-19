using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialArticleManager.Application.Articles.Commands.CreateArticle;
using SocialArticleManager.Application.Articles.Queries.GetArticleById;
using SocialArticleManager.Application.Articles.Queries.GetArticlesByTerm;
using SocialArticleManager.Application.Articles.Queries.ListAllArticles;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace SocialArticleManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IMediator _mediator;
        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [SwaggerOperation(Summary = "Creates article")]
        [SwaggerResponse(200)]
        public async Task<IActionResult> Create(CreateArticleCommand createArticleCommand)
        {
            await _mediator.Send(createArticleCommand);
            return Ok();
        }
        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Gets article by id")]
        [SwaggerResponse(200)]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetArticleByIdQuery(id);
            var article = await _mediator.Send(query);
            return Ok(article);
        }
        [HttpGet]
        [SwaggerOperation(Summary = "Gets All Articles")]
        [SwaggerResponse(200)]
        public async Task<IActionResult> GetAll()
        {
            var query = new ListAllArticlesQuery();
            var articles = await _mediator.Send(query);
            return Ok(articles);
        }
        [HttpGet("Search")]
        [SwaggerOperation(Summary = "Gets Articles by term")]
        [SwaggerResponse(200)]
        public async Task<IActionResult> GetArticlesByTerm(string term)
        {
            var query = new GetArticlesByTermQuery(term);
            var articles = await _mediator.Send(query);
            return Ok(articles);
        }
    }
}
