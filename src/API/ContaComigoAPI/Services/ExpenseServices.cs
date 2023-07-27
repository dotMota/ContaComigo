using ContaComigoAPI.Interfaces;
using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public class ExpenseServices : IExpenseService
    {
        private List<ExpenseModel> expenseList;
        private int nextExpenseId;

        public ExpenseServices()
        {
            expenseList = new List<ExpenseModel>();
            nextExpenseId = 1;
        }

        public ExpenseModel CreateExpense(ExpenseModel expense)
        {
            expense.ExpenseId = nextExpenseId;
            nextExpenseId++;
            expenseList.Add(expense);
            return expense;
        }

        public ExpenseModel UpdateExpense(ExpenseModel expense)
        {
            var existingExpense = expenseList.Find(e => e.ExpenseId == expense.ExpenseId);
            if (existingExpense != null)
            {
                existingExpense.ExpenseName = expense.ExpenseName;
                existingExpense.ExpenseDescription = expense.ExpenseDescription;
                existingExpense.ExpenseValue = expense.ExpenseValue;
                existingExpense.ExpensePayDay = expense.ExpensePayDay;
                return existingExpense;
            }
            else
            {
                throw new Exception("Expense not found.");
            }
        }

        public void DeleteExpense(int expenseId)
        {
            var expenseToDelete = expenseList.Find(e => e.ExpenseId == expenseId);
            if (expenseToDelete != null)
            {
                expenseList.Remove(expenseToDelete);
            }
            else
            {
                throw new Exception("Expense not found.");
            }
        }

        public ExpenseModel GetExpenseById(int expenseId)
        {
            var expense = expenseList.Find(e => e.ExpenseId == expenseId);
            if (expense != null)
            {
                return expense;
            }
            else
            {
                throw new Exception("Expense not found.");
            }
        }
    }
}
