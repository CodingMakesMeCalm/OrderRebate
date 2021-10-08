using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class EndCustomer : OrderRebateEntity
    {
        public EndCustomer()
        {
            Orders = new HashSet<Order>();
            RebateLists = new HashSet<RebateList>();
        }

        public int EndCustomerID { get; set; }
        public string EndCustomerName { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RebateList> RebateLists { get; set; }
    }
}
