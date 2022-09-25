using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class,new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        Task<IReadOnlyList<T>> ListAllAsync();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
