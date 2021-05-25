using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDatabase")
        {
            Database.SetInitializer(
            new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> goods { get; set; }

    }
}
