using data_access.Context;
using domain.Entities;
using domain.Repositories;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Implementation
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(ProductManagementDbContext context) : base(context)
        {
        }
    }
}
