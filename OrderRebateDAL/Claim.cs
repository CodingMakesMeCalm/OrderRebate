using System;
using System.Collections.Generic;

#nullable disable

namespace OrderRebateDAL
{
    public partial class Claim : OrderRebateEntity
    {
        public int ClaimID { get; set; }
        public int SalesID { get; set; }
        public int RebateListID { get; set; }
        public decimal Amount { get; set; }

        public virtual RebateList RebateList { get; set; }
        public virtual Sale Sales { get; set; }
    }
}
