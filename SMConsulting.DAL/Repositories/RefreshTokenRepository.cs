using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;

namespace SMConsulting.DAL.Repositories
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        private readonly SmDbContext _context;
        public RefreshTokenRepository(SmDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task AddAsync(RefreshToken token)
        {
            await Table.AddAsync(token);
            await _context.SaveChangesAsync();
        }
        public async Task<RefreshToken?> GetByTokenAsync(string token)
        {
            return await Table
                .FirstOrDefaultAsync(x => x.RefreshTokenToken == token);
        }

        public async Task<List<RefreshToken>> GetUserTokensAsync(int userId)
        {
            return await Table
                .Where(x => x.RefreshTokenUserId == userId && !x.RefreshTokenIsRevoked)
                .ToListAsync();
        }

        public async Task UpdateAsync(RefreshToken token)
        {
            Table.Update(token);
            await _context.SaveChangesAsync();
        }

    }
}
