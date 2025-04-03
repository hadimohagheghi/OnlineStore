

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineStore.Infrastructures.Data.SqlServer.Order
{
    public class OrderConfig : IEntityTypeConfiguration<Core.Domain.Order.Order>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Order.Order> builder)
        {
            builder .HasKey (o => o.Id);

            builder.Property(o => o.CreateDate)
                .HasDefaultValueSql("GETUTCDATE()");



            //تنظیم روابط بین سفارش و مشتری
            builder.HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId);


            // ایجاد ایندکس روی CustomerId برای بهبود عملکرد جستجوها
            builder.HasIndex(o => o.CustomerId);




        }
    }
}
