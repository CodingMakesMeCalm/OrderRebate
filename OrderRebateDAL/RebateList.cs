using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class RebateList : OrderRebateEntity
    {
        public RebateList()
        {
            Claims = new HashSet<Claim>();
        }

        public int RebateListID { get; set; }
        public int ProductID { get; set; }
        public int EndCustomerID { get; set; }
        public decimal Rate { get; set; }

        public virtual EndCustomer EndCustomer { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Claim> Claims { get; set; }
    }
}
