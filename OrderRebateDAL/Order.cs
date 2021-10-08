using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class Order : OrderRebateEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }
        public int SalesID { get; set; }
        public int EndCustomerID { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }

        public virtual EndCustomer EndCustomer { get; set; }
        public virtual Sale Sales { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
