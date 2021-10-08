using System;
using Xunit;
using OrderRebateViewModels;
using OrderRebateDAL;
using OrderRebateDAL.DAO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderRebateTests
{
    public class OrderRebateViewModelsTest
    {
        [Fact]
        public async Task Student_GetAllTest()
        {
            List<OrderDetailViewModel> vms = new List<OrderDetailViewModel>();
            OrderDetailViewModel ord = new OrderDetailViewModel();
            try
            {
                vms = await ord.GetAllOrdersr();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error - " + ex.Message);
            }
            Assert.True(vms.Count > 0);
        }
    }
}
