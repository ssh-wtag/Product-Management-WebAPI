using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        //Ont-to-One
        public int SellerId { get; set; }
        public Seller? Seller { get; set; }

        //Many-to-Many
        public List<Category>? Category { get; set; }
    }
}
