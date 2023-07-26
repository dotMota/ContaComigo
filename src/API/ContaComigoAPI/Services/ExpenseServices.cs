using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public class ExpenseServices : IExpenseService
    {
        private List<Expense> expenseList;
        private int nextExpenseId;

        public ExpenseServices()
        {
            expenseList = new List<Expense>();
            nextExpenseId = 1;
        }

        public Expense CreateExpense(Expense expense)
        {
            expense.IdExpense = nextExpenseId;
            nextExpenseId++;
            expenseList.Add(expense);
            return expense;
        }

        public Expense UpdateExpense(Expense expense)
        {
            var existingExpense = expenseList.Find(e => e.IdExpense == expense.IdExpense);
            if (existingExpense != null)
            {
                existingExpense.Name = expense.Name;
                existingExpense.Description = expense.Description;
                existingExpense.Value = expense.Value;
                existingExpense.PayDay = expense.PayDay;
                return existingExpense;
            }
            else
            {
                throw new Exception("Expense not found.");
            }
        }

        public void DeleteExpense(int expenseId)
        {
            var expenseToDelete = expenseList.Find(e => e.IdExpense == expenseId);
            if (expenseToDelete != null)
            {
                expenseList.Remove(expenseToDelete);
            }
            else
            {
                throw new Exception("Expense not found.");
            }
        }

        public Expense GetExpenseById(int expenseId)
        {
            var expense = expenseList.Find(e => e.IdExpense == expenseId);
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
