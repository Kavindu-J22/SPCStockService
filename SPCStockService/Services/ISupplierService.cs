using SPCStockService.Models;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public interface ISupplierService
    {
        Task<Supplier> RegisterSupplierAsync(Supplier supplier);
        Task<Supplier> GetSupplierByIdAsync(int id);
    }
}