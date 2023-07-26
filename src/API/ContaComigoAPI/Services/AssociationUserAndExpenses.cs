using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public class UserExpenseAssociation
    {
        // Classe interna para armazenar as informações de associação
        public class Association
        {
            public int UserId { get; set; }
            public int ExpenseId { get; set; }
        }

        private List<Association> associations;
        private List<ExpensePayment> expensePayments;

        public UserExpenseAssociation()
        {
            associations = new List<Association>();
            expensePayments = new List<ExpensePayment>();
        }

        // Método para associar um usuário a uma despesa pelo ID
        public void AssociateUserWithExpense(int userId, int expenseId)
        {
            // Verifica se a associação já existe antes de adicionar
            if (!AssociationExists(userId, expenseId))
            {
                associations.Add(new Association { UserId = userId, ExpenseId = expenseId });
            }
        }

        // Método para verificar se uma associação já existe
        private bool AssociationExists(int userId, int expenseId)
        {
            return associations.Exists(a => a.UserId == userId && a.ExpenseId == expenseId);
        }

        // Método para registrar um pagamento específico de uma despesa feita por um usuário
        public void RecordExpensePayment(ExpensePayment expensePayment)
        {
            // Realize as validações e lógica necessárias aqui antes de adicionar o pagamento
            expensePayments.Add(expensePayment);
        }

        // Método para obter todas as associações
        public List<Association> GetAllAssociations()
        {
            return associations;
        }

        // Método para obter todos os pagamentos de despesas
        public List<ExpensePayment> GetAllExpensePayments()
        {
            return expensePayments;
        }
    }
}
