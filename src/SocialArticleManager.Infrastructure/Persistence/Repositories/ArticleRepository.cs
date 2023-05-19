using Microsoft.EntityFrameworkCore;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.Repository;
using SocialArticleManager.Domain.Aggregates.ArticleAggregate.ValueObjects;

namespace SocialArticleManager.Infrastructure.Persistence.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly SocialArticleManagerContext _context;
        public ArticleRepository(SocialArticleManagerContext context)
        {

            _context = context;

        }
        public async Task<Article> AddAsync(Article entity)
        {
            await _context.Articles.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public Task DeleteAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> GetAllAsync()
        {
            return await _context.Articles.AsNoTracking().ToListAsync();
        }

        public async Task<Article> GetByIdAsync(ArticleId id)
        {
            return await _context.Articles.AsNoTracking().Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Article>> GetByIdsAsync(List<ArticleId> ids)
        {
            return await _context.Articles.AsNoTracking().Where(a => ids.Contains(a.Id)).ToListAsync();
        }

        public async Task<Article> Update(Article entity)
        {
            _context.Articles.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
