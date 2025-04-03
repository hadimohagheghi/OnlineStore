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
        /// <summary>
        /// مبلغ کل
        /// </summary>
        public int TotalAmount { get; set; }//Computed column فیلد محاسباتی

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int OrderId { get; set; } //کلید خارجی
        public int ProductId { get; set; } //کلید خارجی
    }

}
