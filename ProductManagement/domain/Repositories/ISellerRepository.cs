﻿using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Repositories
{
    public interface ISellerRepository : IGenericRepository<Seller>
    {
        Task<IEnumerable<Product>> ProductsBySellerId(int sellerId);
    }
}
