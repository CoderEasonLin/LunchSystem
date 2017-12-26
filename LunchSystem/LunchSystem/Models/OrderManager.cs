using System.Collections.Generic;
using LunchSystem.Models.Interfaces;

namespace LunchSystem.Models
{
    public class OrderManager : IOrderManager
    {
        public OrderManager()
        {
            Orders = new List<OrderRequest>();
        }

        public void Order(OrderRequest request)
        {
            Orders.Add(request);
        }

        public List<OrderRequest> Orders { get; set; }
    }
}