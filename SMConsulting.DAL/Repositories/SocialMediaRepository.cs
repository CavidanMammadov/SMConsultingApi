using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;

namespace SMConsulting.DAL.Repositories
{
    public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
    {
        private readonly SmDbContext _context;
        public SocialMediaRepository(SmDbContext context):base(context) 
        {
            _context = context;
        }
        public async Task<bool> IsExistAsync(int id)
    => await Table.AnyAsync(x => x.SocialMediaId == id);

        public async Task<bool> RemoveAsync(int id)
        {
            int result = await Table.Where(x => x.SocialMediaId == id).ExecuteDeleteAsync();
            return result > 0;
        }
    }
}
