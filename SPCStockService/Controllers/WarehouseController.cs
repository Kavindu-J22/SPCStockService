using Microsoft.AspNetCore.Mvc;
using SPCStockService.Models;
using SPCStockService.Services;
using System.Threading.Tasks;

namespace SPCStockService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;

        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpPut("update-stock")]
        public async Task<IActionResult> UpdateStock([FromBody] Warehouse stockUpdate)
        {
            var result = await _warehouseService.UpdateStockAsync(stockUpdate);
            return Ok(result);
        }
    }
}