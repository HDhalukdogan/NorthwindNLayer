using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductAsync(Expression<Func<Product,bool>> predicate);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<Product> CreateProdtuctAsync(Product product);
        Task<Product> UpdateProdtuctAsync(Product product);
        void DeleteProdtuctAsync(int id);
    }
}
