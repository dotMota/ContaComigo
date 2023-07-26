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
            var createdExpense = _expenseService.CreateExpense(expense);
            return Ok(createdExpense);
        }

        [HttpPut("{expenseId}")]
        public IActionResult UpdateExpense(int expenseId, [FromBody] Expense expense)
        {
            try
            {
                // Verifica se o ID informado corresponde ao ID no corpo da requisição
                if (expenseId != expense.IdExpense)
                {
                    return BadRequest("ID mismatch between route and request body.");
                }

                var updatedExpense = _expenseService.UpdateExpense(expense);
                return Ok(updatedExpense);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("{expenseId}")]
        public IActionResult DeleteExpense(int expenseId)
        {
            try
            {
                _expenseService.DeleteExpense(expenseId);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("{expenseId}")]
        public IActionResult GetExpenseById(int expenseId)
        {
            try
            {
                var expense = _expenseService.GetExpenseById(expenseId);
                return Ok(expense);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
