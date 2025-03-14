using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineStore.Infrastructures.Data.SqlServer.Customer
{
    public class CustomerConfig : IEntityTypeConfiguration<Core.Domain.Customer.Customer>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Customer.Customer> builder)
        {
            builder.HasKey(c => c.Id);
           


            //Entity Properties  ویژگی های موجودیت
            //شامل
            //تنظیمات پیش فرض
            //مقادیر محاسباتی
            //و....

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);


            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(80);

            builder.Property(c => c.Password)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(c => c.Address )
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.PhoneNumber )
                .IsRequired()
                .HasMaxLength(50);
           



            //.....
        }
    }
}
