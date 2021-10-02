using OrderDelivery.Business.Orders.DTO;
using OrderDelivery.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderDelivery.Business.Orders
{
    public interface IOrderService
    {
        public Task<int> AddAsync(OrderRequest orderRequest);

        public Task<List<OrderResponse>> GetAllOrdersAsync();
    }
}
