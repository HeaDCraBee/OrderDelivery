using OrderDelivery.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderDelivery.DAL.Repository
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly OrderDbContext _context;

        public OrdersRepository(OrderDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddAsync(Order order)
        {
            if (order == null)
                throw new ArgumentNullException("Received an empty order");

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return order.Id;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
