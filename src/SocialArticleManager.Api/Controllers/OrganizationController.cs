using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialArticleManager.Api.Application.Organizations.Commands.CreateOrganization;
using SocialArticleManager.Api.Application.Organizations.Queries.ListAllOrganizations;
namespace SocialArticleManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private IMediator _mediator;
        public OrganizationController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrganizationCommand createOrganizationCommand)
        {
            await _mediator.Send(createOrganizationCommand);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrganizations()
        {
            var query = new ListAllOrganizationsQuery();
            var organizations = await _mediator.Send(query);
            return Ok(organizations);
        }
    }
}
