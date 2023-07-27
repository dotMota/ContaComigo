using ContaComigoAPI.Interfaces;
using ContaComigoAPI.Models;
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

        [HttpPost("CreateExpense")]
        public IActionResult CreateExpense([FromBody] ExpenseModel expense)
        {
            var createdExpense = _expenseService.CreateExpense(expense);
            return Ok(createdExpense);
        }

        [HttpPut("UpdateExpenseById")]
        public IActionResult UpdateExpense(int expenseId, [FromBody] ExpenseModel expense)
        {
            try
            {
                // Verifica se o ID informado corresponde ao ID no corpo da requisição
                if (expenseId != expense.ExpenseId)
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

        [HttpDelete("DeleteExpenseById")]
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

        [HttpGet("GetExpenseById")]
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
