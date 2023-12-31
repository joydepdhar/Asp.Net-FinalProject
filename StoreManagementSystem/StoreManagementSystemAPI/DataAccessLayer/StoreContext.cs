using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StoreContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductCustomer> ProductCustomers { get; set;}

        public DbSet<Review> Reviews { get; set; }

        public DbSet<FeedBack> FeedBacks { get; set; }

    }
}
