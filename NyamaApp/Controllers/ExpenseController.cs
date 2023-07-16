using Business.Models;
using Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly ExpenseService _expenseService;

        public ExpenseController()
        {
            _expenseService = new ExpenseService();
        }

        [HttpGet("filter")]
        public IActionResult Get([FromQuery] FilterExpenseModel expense)
        {
            return Ok(_expenseService.FilterExpense(expense));
        }

        [HttpGet("allExpenseType")]
        public IActionResult GetAllExpenseType()
        {
            return Ok(_expenseService.GetAllExpenseType());
        }

        [HttpGet("id")]
        public IActionResult GetExpenseById([FromQuery] int id)
        {
            return Ok(_expenseService.GetExpenseById(id));
        }

        [HttpPost]
        public bool Post(ExpenseModel expense)
        {
            _expenseService.AddExpense(expense);
            return true;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ExpenseModel expense)
        {
            return Ok(_expenseService.UpdateExpense(expense));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_expenseService.DeleteExpense(id));
        }
    }
}
