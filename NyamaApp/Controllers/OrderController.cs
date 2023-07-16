using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }

        [HttpGet("filter")]
        public IActionResult Get([FromQuery] FilterOrderModel filter)
        {
            return Ok(_orderService.FilterOrder(filter));
        }

        [HttpPost]
        public bool Post(OrderModel order)
        {
            _orderService.AddOrder(order);
            return true;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] OrderModel order)
        {
            return Ok(_orderService.UpdateOrder(order));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_orderService.DeleteOrder(id));
        }
    }
}
