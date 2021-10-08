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
    public class OrderOperations
    {
        readonly IRepository<VW_ALLINFO_OrderDetail> repository;

        public OrderOperations()
        {
            repository = new OrderRebateRepository<VW_ALLINFO_OrderDetail>();
        }
        public async Task<List<VW_ALLINFO_OrderDetail>> GetOrderDetailsBySaleName(string saleN)
        {
            List<VW_ALLINFO_OrderDetail> selected = new List<VW_ALLINFO_OrderDetail>();
            try
            {
                selected = await repository.GetSome(ord => ord.SalesName == saleN);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return selected;
        }

        public async Task<List<VW_ALLINFO_OrderDetail>> GetOrderDetailsByProductName(string proName)
        {
            List<VW_ALLINFO_OrderDetail> selected = new List<VW_ALLINFO_OrderDetail>();
            try
            {
                selected = await repository.GetSome(ord => ord.ProductName == proName);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return selected;
        }

        public async Task<List<VW_ALLINFO_OrderDetail>> GetOrderDetailsByEndCustomer(string custname)
        {
            List<VW_ALLINFO_OrderDetail> selected = new List<VW_ALLINFO_OrderDetail>();
            try
            {
                selected = await repository.GetSome(ord => ord.EndCustomerName == custname);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return selected;
        }

        public async Task<List<VW_ALLINFO_OrderDetail>> GetAllOrdersr()
        {
            List<VW_ALLINFO_OrderDetail> selected = new List<VW_ALLINFO_OrderDetail>();
            try
            {
                selected = await repository.GetAll();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return selected;
        }

    }
}
