using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeChallange10.Models;

using Microsoft.EntityFrameworkCore;

namespace CodeChallange10.Repository
{
    public class OrderService : IOrderRepository
    {
        private readonly NorthwindContext _context;

        public OrderService(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Employee)
                .Include(o => o.ShipViaNavigation)
                .ToListAsync();
        }

     
        public async Task<int> PlaceOrderAsync(Order order)
        {
            if (order == null)
                throw new ArgumentNullException(nameof(order));

            _context.Orders.Add(order);
            return await _context.SaveChangesAsync();
        }
    }
}
