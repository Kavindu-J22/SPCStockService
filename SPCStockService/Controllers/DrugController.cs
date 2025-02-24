using Microsoft.AspNetCore.Mvc;
using SPCStockService.Models;
using SPCStockService.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPCStockService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrugController : ControllerBase
    {
        private readonly IDrugService _drugService;

        public DrugController(IDrugService drugService)
        {
            _drugService = drugService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchDrugs([FromQuery] string name)
        {
            var drugs = await _drugService.SearchDrugsAsync(name);
            return Ok(drugs);
        }

        [HttpPost]
        public async Task<IActionResult> AddDrug([FromBody] Drug drug)
        {
            var result = await _drugService.AddDrugAsync(drug);
            return Ok(result);
        }
    }
}