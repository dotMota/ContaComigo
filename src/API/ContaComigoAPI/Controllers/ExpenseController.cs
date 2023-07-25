using ContaComigoAPI.Models;
using ContaComigoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContaComigoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpPost]
        public IActionResult CreateExpense([FromBody] Expense expense)
        {
            Expense createdExpense = _expenseService.CreateExpense(expense);
            return Ok(createdExpense);
        }
    }
}
