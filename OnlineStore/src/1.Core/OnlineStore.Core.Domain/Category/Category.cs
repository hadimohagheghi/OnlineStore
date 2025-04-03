using System.Collections.Generic;
using OnlineStore.Core.Domain.Product;

namespace OnlineStore.Core.Domain.Category
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //لیست محصولات موجود در این دسته‌بندی
        public ICollection<Product> ?Products { get; set; }



    }
}
