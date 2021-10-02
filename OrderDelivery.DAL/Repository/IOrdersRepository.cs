using OrderDelivery.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OrderDelivery.DAL.Repository
{
    public interface IOrdersRepository
    {
        public Task<int> AddAsync(Order order);

        public Task<List<Order>> GetAllOrdersAsync();
    }
}
