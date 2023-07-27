using ContaComigoAPI.Models;
using ContaComigoAPI.Services;

public static class SendCode
{
    public static async Task<bool> SendEmailCodeAsync(string userEmail, string verificationCode)
    {
        if (!string.IsNullOrEmpty(userEmail))
        {
            // [ ] Lógica para enviar o código de verificação (verificationCode) por email para o userEmail

            return true;
        }
        else
        {
            return false;
        }
    }

    public static async Task<bool> SendPhoneCodeAsync(string userPhoneNumber, string verificationCode)
    {
        if (!string.IsNullOrEmpty(userPhoneNumber))
        {
            // [ ] Lógica para enviar o código de verificação (verificationCode) por SMS para o userPhoneNumber
            return true;
        }
        else
        {
            return false;
        }
    }
}