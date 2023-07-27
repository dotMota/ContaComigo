namespace ContaComigoAPI.Models
{
    public class ExpenseModel
    {
        public int ExpenseId { get; set; }
        public string ExpenseName { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal ExpenseValue { get; set; }
        public DateOnly ExpensePayDay { get; set; }
    }
}
