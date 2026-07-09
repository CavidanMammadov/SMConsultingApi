using Microsoft.EntityFrameworkCore;
using SMConsulting.Core;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;

namespace SMConsulting.DAL.Repositories
{
    public class SectorHelpRepository:GenericRepository<SectorHelp>, ISectorHelpRepository
    {
        private readonly SmDbContext _context;
        public SectorHelpRepository(SmDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsExistAsync(int id)
      => await Table.AnyAsync(x => x.SectorHelpId == id);

        public async Task<bool> RemoveAsync(int id)
        {
            int result = await Table.Where(x => x.SectorHelpId == id).ExecuteDeleteAsync();
            return result > 0;
        }
    }
}
