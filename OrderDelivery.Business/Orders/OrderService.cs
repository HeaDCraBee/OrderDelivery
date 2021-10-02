using OrderDelivery.Business.Orders.DTO;
using OrderDelivery.DAL.Repository;
using OrderDelivery.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderDelivery.Business.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository _ordersRepository;

        public OrderService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public async Task<int> AddAsync(OrderRequest orderRequest)
        {
            return await _ordersRepository.AddAsync(Mapper.Map(orderRequest, new Order()));
        }

        public async Task<List<OrderResponse>> GetAllOrdersAsync()
        {
            var ordersList = await _ordersRepository.GetAllOrdersAsync();

            var orderResponseList = new List<OrderResponse>();

            foreach (var order in ordersList)
            {
                orderResponseList.Add(Mapper.Map(new OrderResponse(), order));
            }

            return orderResponseList;
        }
    }
}
