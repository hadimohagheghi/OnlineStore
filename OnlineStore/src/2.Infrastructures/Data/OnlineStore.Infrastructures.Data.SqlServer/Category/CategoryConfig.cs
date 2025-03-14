using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineStore.Infrastructures.Data.SqlServer.Category
{
    public class CategoryConfig :IEntityTypeConfiguration<Core.Domain.Category.Category>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Category.Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
