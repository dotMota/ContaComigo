namespace ContaComigoAPI.Models
{
    public class UserSensitiveInfoModel
    {
        // Usa UserID para Vincular
        public string UserPasswordHash { get; set; }

        // Usos Pincode:
        // 1. Confirmar Email e/ou Telefone;
        // 2. redefinição de senha.
        // public string UserPincode { get; set; }
    }
}
