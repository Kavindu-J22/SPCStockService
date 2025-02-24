using Microsoft.AspNetCore.Mvc;
using SPCStockService.Models;
using SPCStockService.Services;
using System.Threading.Tasks;

namespace SPCStockService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            _supplierService = supplierService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterSupplier([FromBody] Supplier supplier)
        {
            var result = await _supplierService.RegisterSupplierAsync(supplier);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier(int id)
        {
            var supplier = await _supplierService.GetSupplierByIdAsync(id);
            if (supplier == null)
                return NotFound();
            return Ok(supplier);
        }
    }
}