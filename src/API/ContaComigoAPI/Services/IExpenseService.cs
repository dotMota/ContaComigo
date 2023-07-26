using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public interface IExpenseService
    {
        Expense CreateExpense(Expense expense);
        Expense UpdateExpense(Expense expense);
        void DeleteExpense(int expenseId);
        Expense GetExpenseById(int expenseId);
    }
}
