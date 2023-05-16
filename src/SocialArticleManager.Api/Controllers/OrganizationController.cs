using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SocialArticleManager.Api.Application.Organizations.Commands.CreateOrganization;
using SocialArticleManager.Api.Application.Organizations.Queries.ListAllOrganizations;
using SocialArticleManager.Api.Contratcs.Organization.Requests;
using SocialArticleManager.Api.Contratcs.Organization.Responses;

namespace SocialArticleManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IMediator _mediator;
        public OrganizationController(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;

        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateOrganizationRequest createOrganizationRequest)
        {
            var query=_mapper.Map<CreateOrganizationCommand>(createOrganizationRequest);
            var organization= await _mediator.Send(query);
            return Ok(_mapper.Map<OrganizationResponse>(organization));
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrganizations()
        {
            var query = new ListAllOrganizationsQuery();
            var organizations = await _mediator.Send(query);
            return Ok(_mapper.Map<List<OrganizationResponse>>(organizations));
        }
    }
}
