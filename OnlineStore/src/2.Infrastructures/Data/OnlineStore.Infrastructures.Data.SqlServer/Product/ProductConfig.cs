using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.Core.Domain.Product;


namespace OnlineStore.Infrastructures.Data.SqlServer.Product
{

    //همه تنظیماتی که قبلاً برای فیلدهام تو دیتابیس
    //انجام میدادم حالا اینجا انجام میدم
    public class ProductConfig : IEntityTypeConfiguration<Core.Domain.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Product.Product> builder)
        {
            // کلید اصلی
            builder.HasKey(p => p.Id);
            //نام اجباری باشه و حداکثر طولش 100 تا باشه
            //Required = الزامی
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            //میخوام که قیمت مثلا 118 رقم باشه و با دو رقم اعشار
            builder.Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.CreateDate)
                .HasDefaultValueSql("GETUTCDATE()");
            builder.Property (p => p.IsAvailable )
                .HasDefaultValue (true);

            //تنظیم روابط بین محصول و طبقه بندی محصول
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);



        }
    }
}
