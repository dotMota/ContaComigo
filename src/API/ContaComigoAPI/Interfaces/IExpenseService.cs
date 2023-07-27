using ContaComigoAPI.Models;

namespace ContaComigoAPI.Interfaces
{
    public interface IExpenseService
    {
        ExpenseModel CreateExpense(ExpenseModel expense);
        ExpenseModel UpdateExpense(ExpenseModel expense);
        void DeleteExpense(int expenseId);
        ExpenseModel GetExpenseById(int expenseId);
    }
}
