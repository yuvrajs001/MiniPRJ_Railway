using System;
using System.Collections.Generic;
using System.Linq;
using CodeChallange10.Models;


namespace CodeChallange10.Repository
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync();
   
        Task<int> PlaceOrderAsync(Order order);

    }
}