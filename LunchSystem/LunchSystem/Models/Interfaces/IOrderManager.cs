using System.Collections.Generic;

namespace LunchSystem.Models.Interfaces
{
    public interface IOrderManager
    {
        void Order(OrderRequest request);
        List<OrderRequest> Orders { get; set; }
    }
}