﻿using System;
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
            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);



            //.....
        }
    }
}
