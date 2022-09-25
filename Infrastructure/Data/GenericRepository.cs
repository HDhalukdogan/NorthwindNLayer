using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly NorthwindContext _context;

        public GenericRepository(NorthwindContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            var t = await _context.Set<T>().FirstOrDefaultAsync(predicate);
            return t;
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            var tList = await _context.Set<T>().ToListAsync();
            return tList;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
