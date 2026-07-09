using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Repositories
{
    public interface IMemberRepository :IGenericRepository<Member>
    {
        Task<bool> IsExistAsync(int id);
        Task<bool> RemoveAsync(int id);
    }
}
