using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class Sale : OrderRebateEntity
    {
        public Sale()
        {
            Claims = new HashSet<Claim>();
            Orders = new HashSet<Order>();
        }

        public int SalesID { get; set; }
        public string SalesName { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
