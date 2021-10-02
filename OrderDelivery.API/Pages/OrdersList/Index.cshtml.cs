using OrderDelivery.API.Controllers;
using OrderDelivery.Business.Orders;
using OrderDelivery.Business.Orders.DTO;
using OrderDelivery.DAL;
using OrderDelivery.DAL.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderDelivery.API.Pages.OrdersList
{
    public class IndexModel : PageModel
    {
        public IEnumerable<OrderResponse> Orders { get; set; }
        private readonly OrderDbContext _orderDbContext;

        public IndexModel(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }


        public async Task OnGet()
        {
            var orderController =
                new OrderController(
                    new OrderService(
                        new OrdersRepository(_orderDbContext)));

            Orders = await orderController.GetAllOrdersAsync();
        }
    }
}
