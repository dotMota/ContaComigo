using ContaComigoAPI.Interfaces;
using ContaComigoAPI.Models;
using static ContaComigoAPI.Services.VerificationServices;

namespace ContaComigoAPI.Services
{
    public class UserServices : IUserService
    {
        private List<UserModel> _users;

        public UserServices()
        {
            _users = new List<UserModel>();
        }

        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            user.UserId = Guid.NewGuid();
            user.UserSensitiveInfo = new UserSensitiveInfoModel
            {
                UserPasswordHash = "" // [ ] Hash 
            };

            bool verifyEmail = true;
            bool verifyPhone = true;
            bool verifyDocument = true;

            if (verifyEmail)
            {
                string verifiedEmail = await VerificationServices.EmailVerification.SendVerificationCode(user.UserEmail);
                user.UserEmail = verifiedEmail;
            }

            if (verifyPhone)
            {
                string verifiedPhone = await VerificationServices.PhoneVerification.SendVerificationCode(user.UserPhoneNumber);
                user.UserPhoneNumber = verifiedPhone;
            }

            if (verifyDocument)
            {
                user.UserDocument = DocumentVerification.NormalizeDocument(user.UserDocument);
            }

            _users.Add(user);

            // [ ] Insere o novo usuário no banco de dados
            return user;
        }


        // Implementação da remoção do usuário
        // Implementação da atualização do usuário
    }
}
