﻿using Microsoft.EntityFrameworkCore;
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


        }

           
    }
}
