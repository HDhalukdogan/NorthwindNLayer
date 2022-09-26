using Core.Entities;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class, new(); 
        IProductRepository ProductRepository { get; }
        Task<int> Complete();
    }
}