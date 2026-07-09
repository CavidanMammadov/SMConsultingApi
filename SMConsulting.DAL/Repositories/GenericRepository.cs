using Microsoft.EntityFrameworkCore;
using SMConsulting.Core.Repositories;
using SMConsulting.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMConsulting.DAL.Repositories
{
    public class GenericRepository<T>(SmDbContext _context) : IGenericRepository<T> where T : class, new()
    {
        protected DbSet<T> Table => _context.Set<T>();
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _context.Set<T>().AddRangeAsync(entities);
        }

        public IQueryable<T> GetAll()
        => Table.AsQueryable();

        public async Task<T?> GetByIdAsync(int id)
            => await Table.FindAsync(id);


        public IQueryable<T> GetWhere(Func<T, bool> expression)
        => Table.Where(expression).AsQueryable();



        public void Remove(T entity)
        => Table.Remove(entity);



        public async Task<int> SaveAsync()
       => await _context.SaveChangesAsync();

        public IQueryable<T> GetWithPagination(int page, int take)
        {
            return _context.Set<T>()
                           .Skip((page - 1) * take)
                           .Take(take);
        }
    }
}
