using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class Product : OrderRebateEntity
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            RebateLists = new HashSet<RebateList>();
        }

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Factory { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<RebateList> RebateLists { get; set; }
    }
}
