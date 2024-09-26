using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities
{
    public class Seller
    {
        [Key]
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        //One-to-Many
        public List<Product>? Products { get; set; }

        //One-to-One
        public Store? Store { get; set; }
    }
}
