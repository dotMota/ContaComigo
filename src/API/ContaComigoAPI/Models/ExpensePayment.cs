namespace ContaComigoAPI.Models
{
    public class ExpensePayment
    {
        public int IdExpensePayment { get; set; }
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
