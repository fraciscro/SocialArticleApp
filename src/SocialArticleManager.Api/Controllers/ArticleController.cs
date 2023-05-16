using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialArticleManager.Api.Application.Articles.Commands.CreateArticle;
using SocialArticleManager.Api.Contratcs.Article.Requests;
using SocialArticleManager.Api.Contratcs.Article.Responses;

namespace SocialArticleManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IMediator _mediator;
        public ArticleController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateArticleRequest createArticleRequest)
        {
            var command= _mapper.Map<CreateArticleCommand>(createArticleRequest);
            var article= await _mediator.Send(command);
            return Ok(_mapper.Map<ArticleResponse>(article));
        }
    }
}
