using Microsoft.AspNetCore.Mvc;
using SPCStockService.Models;
using SPCStockService.Services;
using System.Threading.Tasks;

namespace SPCStockService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("place-order")]
        public async Task<IActionResult> PlaceOrder([FromBody] Order order)
        {
            var result = await _orderService.PlaceOrderAsync(order);
            return Ok(result);
        }
    }
}