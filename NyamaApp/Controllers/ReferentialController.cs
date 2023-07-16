using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferentialController : ControllerBase
    {
        private readonly ReferentialService _referentialService;

        public ReferentialController()
        {
            _referentialService = new ReferentialService();
        }

        [HttpGet("City")]
        public IActionResult GetCityToSelect()
        {
            return Ok(_referentialService.GetCityToSelect());
        }

        [HttpGet("District")]
        public IActionResult GetDistrictToSelect()
        {
            return Ok(_referentialService.GetDistrictToSelect());
        }

        [HttpGet("ExpenseType")]
        public IActionResult GetExpenseTypeToSelect()
        {
            return Ok(_referentialService.GetExpenseTypeToSelect());
        }

        [HttpGet("Category")]
        public IActionResult GetCategoryToSelect()
        {
            return Ok(_referentialService.GetCategoryToSelect());
        }

        [HttpGet("Unit")]
        public IActionResult GetUnitToSelect()
        {
            return Ok(_referentialService.GetUnitToSelect());
        }

        [HttpGet("DistrictByCityId")]

        public IActionResult GetDistrictByCityId(int id)
        {
            return Ok(_referentialService.GetDistrictByCityId(id));
        }
    }
}
