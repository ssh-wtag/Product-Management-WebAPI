using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ISellerRepository SellerRepository { get; }
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IStoreRepository StoreRepository { get; }

        int Save();
    }
}
