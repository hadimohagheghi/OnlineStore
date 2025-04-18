using OnlineStore.Core.Domain.Customer;

namespace OnlineStore.Core.Domain.Order
{
    public class Order
    {
        public int Id { get; set; }
        //public Decimal TotalAmount { get; set; }

        public DateTime CreateDate { get; set; }= DateTime.Now;
        // public List<OrderItem> Items { get; set; }


        //نشان می دهیم که به کدام مشتری تعلق دارد
        public int CustomerId { get; set; }// کلید خارجی 

        //و اینکه به ازای هر سفارش فقط یک مشتری داریم
        public Customer.Customer customer { get; set; }

        public ICollection<OrderItem.OrderItem> OrderItems { get; set; }

        

    }
}
