using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public interface IExpenseService
    {
        Expense CreateExpense(Expense expense);
    }
}
