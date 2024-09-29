using data_access.Context;
using domain.Entities;
using domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access.Implementation
{
    public class SellerRepository : GenericRepository<Seller>, ISellerRepository
    {
        public SellerRepository(ProductManagementDbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Product>> ProductsBySellerId(int sellerId)
        {
            var productsBySeller = await _context.Products
                .Where(p => p.SellerId == sellerId)
                .ToListAsync();

            return productsBySeller;
        }
    }
}
