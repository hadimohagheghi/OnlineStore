using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.Domain.OrderItem
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int TotalAmount { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
