using data_access.Context;
using domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductManagementDbContext _context;

        public ISellerRepository Seller { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICategoryRepository Category { get; private set; }
        public IStoreRepository Store { get; private set; }

        public UnitOfWork(ProductManagementDbContext context)
        {
            _context = context;
            
            Seller = new SellerRepository(_context);
            Product = new ProductRepository(_context);
            Category = new CategoryRepository(_context);
            Store = new StoreRepository(_context);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}
