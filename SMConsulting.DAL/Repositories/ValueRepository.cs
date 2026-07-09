using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Repositories
{
    public class ValueRepository : GenericRepository<Value>, IValueRepository
    {
        private readonly SmDbContext _context;
        public ValueRepository(SmDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> IsExistAsync(int id)
      => await Table.AnyAsync(x => x.ValueId == id);

        public async Task<bool> RemoveAsync(int id)
        {
            int result = await Table.Where(x => x.ValueId == id).ExecuteDeleteAsync();
            return result > 0;
        }
    }
}
