using SMConsulting.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.Core.Repositories
{
    public interface IRefreshTokenRepository : IGenericRepository<RefreshToken>
    {
        Task AddAsync(RefreshToken token);
        Task UpdateAsync(RefreshToken token);

        Task<RefreshToken?> GetByTokenAsync(string token);

        Task<List<RefreshToken>> GetUserTokensAsync(int userId);
    }
}
