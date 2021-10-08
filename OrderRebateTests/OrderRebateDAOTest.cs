using System;
using Xunit;
using OrderRebateDAL;
using OrderRebateDAL.DAO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderRebateTests
{
    public class OrderRebateDAOTest
    {
        [Fact]
        public async Task OrderRebate_GetOrderDetailsBySaleName()
        {
            OrderOperations dao = new OrderOperations();
            List<VW_ALLINFO_OrderDetail> selected = await dao.GetOrderDetailsBySaleName("ABC Company");
            Assert.True(selected.Count > 0);
        }
    }
}
