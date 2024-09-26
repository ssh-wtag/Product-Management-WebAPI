using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ISellerRepository Seller { get; }
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        IStoreRepository Store { get; }

        Task<int> SaveAsync();
    }
}
