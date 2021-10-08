using OrderRebateDAL;
using OrderRebateDAL.DAO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;

namespace OrderRebateViewModels
{
    public class OrderDetailViewModel
    {
        readonly private OrderOperations _dao;

        public string Salesname { get; set; }
        public string Customername { get; set; }
        public string Productname { get; set; }
        public string Factory { get; set; }
        public int Quantity { get; set; }
        public decimal Unitprice { get; set; }
        public float Discount { get; set; }
        public decimal Totalprice { get; set; }

        public OrderDetailViewModel()
        {
            _dao = new OrderOperations();
        }

        public async Task<List<OrderDetailViewModel>> GetBySalesName()
        {
            List<OrderDetailViewModel> allVMs = new List<OrderDetailViewModel>();
            try
            {
                List<VW_ALLINFO_OrderDetail> selected = await _dao.GetOrderDetailsBySaleName(Salesname);
                foreach (VW_ALLINFO_OrderDetail od in selected)
                {
                    OrderDetailViewModel OrderRebateVM = new OrderDetailViewModel
                    {
                        Salesname = od.SalesName,
                        Customername = od.EndCustomerName,
                        Productname = od.ProductName,
                        Factory = od.Factory,
                        Quantity = od.Quantity,
                        Unitprice = od.UnitPrice,
                        Discount = (float)od.Discount,
                        Totalprice = od.TotalPrice
                    };
                    allVMs.Add(OrderRebateVM);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return allVMs;
        }


        public async Task<List<OrderDetailViewModel>> GetByCustomerName()
        {
            List<OrderDetailViewModel> allVMs = new List<OrderDetailViewModel>();
            try
            {
                List<VW_ALLINFO_OrderDetail> selected = await _dao.GetOrderDetailsByEndCustomer(Customername);
                foreach (VW_ALLINFO_OrderDetail od in selected)
                {
                    OrderDetailViewModel OrderRebateVM = new OrderDetailViewModel
                    {
                        Salesname = od.SalesName,
                        Customername = od.EndCustomerName,
                        Productname = od.ProductName,
                        Factory = od.Factory,
                        Quantity = od.Quantity,
                        Unitprice = od.UnitPrice,
                        Discount = (float)od.Discount,
                        Totalprice = od.TotalPrice
                    };
                    allVMs.Add(OrderRebateVM);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return allVMs;
        }


        public async Task<List<OrderDetailViewModel>> GetByProductName()
        {
            List<OrderDetailViewModel> allVMs = new List<OrderDetailViewModel>();
            try
            {
                List<VW_ALLINFO_OrderDetail> selected = await _dao.GetOrderDetailsByProductName(Productname);
                foreach (VW_ALLINFO_OrderDetail od in selected)
                {
                    OrderDetailViewModel OrderRebateVM = new OrderDetailViewModel
                    {
                        Salesname = od.SalesName,
                        Customername = od.EndCustomerName,
                        Productname = od.ProductName,
                        Factory = od.Factory,
                        Quantity = od.Quantity,
                        Unitprice = od.UnitPrice,
                        Discount = (float)od.Discount,
                        Totalprice = od.TotalPrice
                    };
                    allVMs.Add(OrderRebateVM);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return allVMs;
        }


        public async Task<List<OrderDetailViewModel>> GetAllOrdersr()
        {
            List<OrderDetailViewModel> allVMs = new List<OrderDetailViewModel>();
            try
            {
                List<VW_ALLINFO_OrderDetail> selected = await _dao.GetAllOrdersr();
                foreach (VW_ALLINFO_OrderDetail od in selected)
                {
                    OrderDetailViewModel OrderRebateVM = new OrderDetailViewModel
                    {
                        Salesname = od.SalesName,
                        Customername = od.EndCustomerName,
                        Productname = od.ProductName,
                        Factory = od.Factory,
                        Quantity = od.Quantity,
                        Unitprice = od.UnitPrice,
                        Discount = (float)od.Discount,
                        Totalprice = od.TotalPrice
                    };
                    allVMs.Add(OrderRebateVM);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                throw;
            }
            return allVMs;
        }
    }
}
