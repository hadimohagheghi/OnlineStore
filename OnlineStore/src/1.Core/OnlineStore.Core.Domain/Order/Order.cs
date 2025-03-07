using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Domain.Order
{
    public class Order
    {
        public int Id { get; set; }
        //public Decimal TotalAmount { get; set; }

        public DateTime CreateDate { get; set; }
        // public List<OrderItem> Items { get; set; }


    }
}
