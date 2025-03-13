using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OnlineStore.Core.Domain.Product;
using OnlineStore.Infrastructures.Data.SqlServer.Customer;
using OnlineStore.Infrastructures.Data.SqlServer.Order;
using OnlineStore.Infrastructures.Data.SqlServer.Product;

namespace OnlineStore.Infrastructures.Data.SqlServer.Common
{
    public class OnlineStoreCommandDbContext : DbContext
    {
        public OnlineStoreCommandDbContext(DbContextOptions<OnlineStoreCommandDbContext> options) : base(options)
        {
        }

        public DbSet<Core.Domain.Product.Product> Products { get; set; }
        public DbSet<Core.Domain.Customer.Customer> Customers { get; set; }
        public DbSet <Core.Domain.Order.Order> Orders { get; set; }
        //....

        //اینو فعلا می نویسیم تا بعدا تکمیلش کنیم
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //اینجا باید فایل های کانفیگ رو دیبی کانتکست اطلاع بدیم تا بره اعمال کنه
            modelBuilder.ApplyConfiguration(new ProductConfig());

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CustomerConfig());
            base.OnModelCreating(modelBuilder);

            modelBuilder .ApplyConfiguration(new OrderConfig());
            base.OnModelCreating(modelBuilder);
        }

       
    }
}
