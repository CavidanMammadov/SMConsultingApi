using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;

namespace SMConsulting.DAL.Repositories
{
    public class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        private readonly SmDbContext _context;
        public MemberRepository(SmDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsExistAsync(int id)
      => await Table.AnyAsync(x => x.MemberId == id);

        public async Task<bool> RemoveAsync(int id)
        {
            int result = await Table.Where(x => x.MemberId == id).ExecuteDeleteAsync();
            return result > 0;
        }
    }
}
