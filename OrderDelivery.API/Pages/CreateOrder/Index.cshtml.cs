using OrderDelivery.API.Controllers;
using OrderDelivery.Business.Orders;
using OrderDelivery.Business.Orders.DTO;
using OrderDelivery.DAL;
using OrderDelivery.DAL.Repository;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderDelivery.API.Pages.CreateOrder
{
    public class IndexModel : PageModel
    {
        private readonly OrderDbContext _orderDbContext;

        [BindProperty]
        public OrderRequest Order { get; set; }

        public IndexModel(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var orderController =
                new OrderController(
                    new OrderService(
                        new OrdersRepository(_orderDbContext)));

            if (!ModelState.IsValid)
                return Page();

            await orderController.AddOrderAsync(Order);
            return RedirectToPage("/OrdersList/Index");
        }
    }
}
