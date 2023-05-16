using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.Repository;
using SocialArticleManager.Api.Domain.Aggregates.OrganizationAggregate.ValueObjects;

namespace SocialArticleManager.Api.Infrastructure.Persistence.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly SocialArticleManagerContext _context;
        public OrganizationRepository(SocialArticleManagerContext context)
        {

            _context = context;

        }
        public async Task<Organization> AddAsync(Organization entity)
        {
           await _context.AddAsync(entity);
           await _context.SaveChangesAsync();
           return entity;
        }

        public async Task DeleteAsync(Organization entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
          
        }

        public async Task<List<Organization>> GetAllAsync()
        {
           return await _context.Organizations.AsNoTracking().ToListAsync();    
        }

        public async Task<Organization> GetByIdAsync(OrganizationId id)
        {
            return await _context.Organizations.AsNoTracking().Where(o => o.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Organization> Update(Organization entity)
        {
             _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
