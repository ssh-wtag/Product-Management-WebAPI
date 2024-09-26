using data_access.Context;
using domain.Entities;
using domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Implementation
{
    internal class CategoryRepository : GenericRepository<Category>, ICategoryRepository    
    {
        public CategoryRepository(ProductManagementDbContext context) : base(context)
        {
        }
    }
}
