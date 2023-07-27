namespace ContaComigoAPI.Models
{
    public class ExpensePayment
    {
        //Usa UserID e ExpenseID para vincular 'N' Expenses a 'M' Users   
        public int IdExpensePayment { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
