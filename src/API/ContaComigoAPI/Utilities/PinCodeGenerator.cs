namespace ContaComigoAPI.Utilities
{
    public class PinCodeGenerator
    {
        private static readonly Random random = new Random();

        public static string GeneratePinCode()
        {
            return random.Next(100000, 999999).ToString("D6");
        }
        // Usos Pincode:
        // 1. Confirmar Email e/ou Telefone;
        // 2. Recuperação de senha.
    }
}
