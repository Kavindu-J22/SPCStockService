using SPCStockService.Models;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public interface IWarehouseService
    {
        Task<Warehouse> UpdateStockAsync(Warehouse stockUpdate);
    }
}