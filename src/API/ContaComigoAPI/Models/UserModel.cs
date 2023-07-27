namespace ContaComigoAPI.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; } // Utilizando o tipo Guid para armazenar o UUID
        public string UserName { get; set; } 
        public string UserEmail { get; set; }
        public string UserDocument { get; set; }
        public string UserPhoneNumber { get; set; }
    }
}
