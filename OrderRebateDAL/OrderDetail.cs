using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class OrderDetail : OrderRebateEntity
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public string Description { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
