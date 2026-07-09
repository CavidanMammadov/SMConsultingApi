using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Entities;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;

namespace SMConsulting.DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly SmDbContext _context;
        public UserRepository(SmDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<bool> IsExistAsync(int id)
     => await Table.AnyAsync(t => t.UserId == id);

        public async Task<bool> RemoveAsync(int id)
        {
            int result = await Table.Where(t => t.UserId == id).ExecuteDeleteAsync();
            return result > 0;
        }
        public async Task<User?> GetUserByUserNameAsync(string username)
        {
            return await Table.Where(t => t.UserUserName == username).FirstOrDefaultAsync();
        }
    }

}
