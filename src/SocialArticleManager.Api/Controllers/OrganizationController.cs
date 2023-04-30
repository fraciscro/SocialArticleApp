using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Infrastructure.Persistence;

namespace SocialArticleManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        private SocialArticleManagerContext _context;
        public OrganizationController(SocialArticleManagerContext context)
        {
            _context = context;

        }
        [HttpPost]
        public async Task<IActionResult> Create(string name, string url)
        {
            var organization= Organization.Create(name, url);
            await _context.Organizations.AddAsync(organization);
            await _context.SaveChangesAsync();
            return Ok(organization);
        }
    }
}
