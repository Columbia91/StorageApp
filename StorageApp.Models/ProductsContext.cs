using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base ("appConnection")
        {}
        
        public DbSet<Product> Products { get; set; }
    }
}
