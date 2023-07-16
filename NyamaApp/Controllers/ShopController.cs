using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private readonly ShopService _shopService;

        public ShopController()
        {
            _shopService = new ShopService();
        }

        [HttpGet("Allshop")]
        public IActionResult getAllShop()
        {
            return Ok(_shopService.getAllShop());
        }

        [HttpGet("filter")]
        public IActionResult Filter([FromQuery] FilterShopModel filter)
        {
            return Ok(_shopService.Filter(filter));
        }

        [HttpPost]
        public bool Post(ShopModel shop)
        {
            _shopService.AddShop(shop);
            return true;
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] ShopModel shop)
        {
            return Ok(_shopService.UpdateShop(shop));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _shopService.DeleteShop(id);
            return Ok();
        }
    }
}
