using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindContext _northwindContext;

        public ProductRepository(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }

        public Task<Product> CreateProdtuctAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProdtuctAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductAsync(Expression<Func<Product, bool>> predicate)
        {
            var product =  await _northwindContext.Products.FirstOrDefaultAsync(predicate);
            return product;
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            var products = await _northwindContext.Products.ToListAsync();
            return products;
        }

        public Task<Product> UpdateProdtuctAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
