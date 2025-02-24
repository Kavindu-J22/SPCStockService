using SPCStockService.Models;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public interface IOrderService
    {
        Task<Order> PlaceOrderAsync(Order order);
    }
}