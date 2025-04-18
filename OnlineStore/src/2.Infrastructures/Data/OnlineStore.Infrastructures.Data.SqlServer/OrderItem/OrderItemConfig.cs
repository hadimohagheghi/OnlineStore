using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructures.Data.SqlServer.OrderItem
{
    public class OrderItemConfig : IEntityTypeConfiguration<Core.Domain.OrderItem.OrderItem>
    {


        public void Configure(EntityTypeBuilder<Core.Domain.OrderItem.OrderItem> builder)
        {
            builder.HasKey(oi =>  oi.Id);

            builder.Property(oi => oi.TotalAmount)
                .HasColumnType("int(10,2)");

            builder.Property(oi => oi.Quantity)
                .HasColumnType("int(10, 2)");
            builder.Property(oi => oi.UnitPrice)
                .HasColumnType("decimal(18,3)");

            builder.Property(oi => oi.TotalAmount)
               .HasComputedColumnSql("[Quantity]*[UnitPrice]");


            //تنظیم روابط بین آیتم سفارش و سفارش
            

            builder.HasOne(oi => oi.Order)//مشخص میکنه که هر (آیتم سفارش) به یک (سفارش) تعلق داره
               .WithMany(o => o.OrderItem)//مشخص میکنه که یک (سفارش) میتونه چندین (آیتم سفارش) داشته باشه
               .HasForeignKey(oi => oi.OrderId);//کلید خارجی  (شناسه سفارش) رو در آیتم سفارش مشخص میکنه

            //تنظیم روابط بین آیتم سفارش و محصول

            builder.HasOne(oi => oi.Product)
              .WithMany(p => p.OrderItem)
              .HasForeignKey(oi => oi.ProductId);




        }


    }
}
