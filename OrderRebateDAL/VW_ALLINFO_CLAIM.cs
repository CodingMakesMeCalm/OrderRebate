using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class VW_ALLINFO_CLAIM : OrderRebateEntity
    {
        public string SalesName { get; set; }
        public string ProductName { get; set; }
        public string EndCustomerName { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
    }
}
