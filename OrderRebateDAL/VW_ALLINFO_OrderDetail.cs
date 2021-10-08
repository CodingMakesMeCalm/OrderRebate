using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class VW_ALLINFO_OrderDetail : OrderRebateEntity
    {
        public string SalesName { get; set; }
        public string EndCustomerName { get; set; }
        public string ProductName { get; set; }
        public string Factory { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
