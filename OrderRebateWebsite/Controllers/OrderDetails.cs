using OrderRebateViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderRebateWebsite.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        [HttpGet("{salesname}")]
        public async Task<IActionResult> GetBySalesname(string salesname)
        {
            List<OrderDetailViewModel> selected = new List<OrderDetailViewModel>();
            try
            {
                OrderDetailViewModel viewModel = new OrderDetailViewModel { Salesname = salesname };
                selected = await viewModel.GetBySalesName();
                return Ok(selected);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }

    [Route("api/[Controller]")]
    [ApiController]
    public class AllOrdersController : ControllerBase
    {
        [HttpGet("")]
        public async Task<IActionResult> GetAllOrders()
        {
            List<OrderDetailViewModel> selected = new List<OrderDetailViewModel>();
            try
            {
                OrderDetailViewModel viewModel = new OrderDetailViewModel();
                selected = await viewModel.GetAllOrdersr();
                return Ok(selected);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Problem in " + GetType().Name + " " + MethodBase.GetCurrentMethod().Name + " " + ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }

}
