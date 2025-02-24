using SPCStockService.Data;
using SPCStockService.Models;
using System.Threading.Tasks;

namespace SPCStockService.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly AppDbContext _context;

        public WarehouseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Warehouse> UpdateStockAsync(Warehouse stockUpdate)
        {
            var warehouse = await _context.Warehouses.FindAsync(stockUpdate.Id);
            if (warehouse == null)
                return null;

            warehouse.Quantity = stockUpdate.Quantity;
            await _context.SaveChangesAsync();
            return warehouse;
        }
    }
}