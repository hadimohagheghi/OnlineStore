using OnlineStore.Core.Domain.Category;


namespace OnlineStore.Core.Domain.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        //?????? ?? ???? ???? 118 ??? ???? ? ?? ?? ??? ?????
        public decimal Price { get; set; }

        //مقادیر پیش فرض رو از کاربر نمیگیریم ، سیستم وارد میکنه
        /// <summary>
        /// تاریخ افزودن محصول
        /// </summary>
        public DateTime CreateDate { get; set; }= DateTime.Now; 
        /// <summary>
        /// آیا در دسترس هست؟
        /// </summary>
        public bool IsAvailable { get; set; }
        //

        //...
        //
        //نشان می دهیم که به کدام طبقه بندی تعلق دارد
        public int CategoryId { get; set; }//کلید خارجی

        //و اینکه به ازای هر محصول فقط یک طبقه بندی محصول داریم
        public Category.Category Category { get; set; }

            public ICollection<OrderItem> OrderItems { get; set; }


    }
}
