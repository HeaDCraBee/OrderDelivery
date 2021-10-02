using Microsoft.AspNetCore.Mvc;
using OrderDelivery.Business.Orders;
using OrderDelivery.Business.Orders.DTO;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OrderDelivery.API.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        
        [HttpPost]
        public async Task<int> AddOrderAsync([FromBody] OrderRequest orderRequest)
        {
            return await _orderService.AddAsync(orderRequest);
        }

        [HttpGet]
        public async Task<List<OrderResponse>> GetAllOrdersAsync()
        {
            return await _orderService.GetAllOrdersAsync();
        }
    }
}
