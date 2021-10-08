using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderRebateDAL.DAO
{
    public class OrderDAO
    {
        readonly IRepository<Order> repository;
        public OrderDAO()
        {
            repository = new OrderRebateRepository<Order>();
        }

        public async Task<Order> GetById(int id)
        {
            Order selectedOrder = null;

            try
            {
                selectedOrder = await repository.GetOne(ord => ord.OrderID == id);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }

            return selectedOrder;
        }


        public async Task<List<Order>> GetAll()
        {
            List<Order> allOrder = new List<Order>();

            try
            {
                allOrder = await repository.GetAll();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }

            return allOrder;
        }


        
    }
}
