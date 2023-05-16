using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Enums;
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
        public async Task<IActionResult> Create(string name, string url,OrganizationType type)
        {
            var organization= Organization.Create(name, url, type);
            await _context.Organizations.AddAsync(organization);
            await _context.SaveChangesAsync();
            return Ok(organization);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllOrganizations()
        {
            var organizations = await _context.Organizations.ToListAsync();
            return Ok(organizations);
        }
    }
}
