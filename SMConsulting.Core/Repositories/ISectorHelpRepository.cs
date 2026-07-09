using SMConsulting.Core.Entities;

namespace SMConsulting.Core.Repositories
{
    public interface ISectorHelpRepository :IGenericRepository<SectorHelp>
    {
        Task<bool> IsExistAsync(int id);
        Task<bool> RemoveAsync(int id);
    }
}
