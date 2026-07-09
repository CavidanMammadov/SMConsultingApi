using SMConsulting.Core.Entities;

namespace SMConsulting.Core.Repositories
{
    public interface IApplymentRepository : IGenericRepository<Applyment>
    {
        Task<bool> IsExistAsync(int id);
        Task<bool> RemoveAsync(int id);
    }
}
