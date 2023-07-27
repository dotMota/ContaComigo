using ContaComigoAPI.Utilities;
using System.Text.RegularExpressions;

namespace ContaComigoAPI.Services
{
    public class VerificationServices
    {
        private static Dictionary<string, string> emailVerificationCodes = new Dictionary<string, string>();
        private static Dictionary<string, string> phoneVerificationCodes = new Dictionary<string, string>();

        public static class EmailVerification
        {
            public static async Task<string> SendVerificationCode(string userEmail)
            {
                string verificationCode = PinCodeGenerator.GeneratePinCode();
                emailVerificationCodes[userEmail] = verificationCode;

                await SendCode.SendEmailCodeAsync(userEmail, verificationCode);

                return userEmail;
            }

            public static bool VerifyCode(string userEmail, string code, out string verifiedEmail)
            {
                verifiedEmail = null;

                if (emailVerificationCodes.TryGetValue(userEmail, out string storedCode))
                {
                    if (string.Equals(storedCode, code, StringComparison.OrdinalIgnoreCase))
                    {
                        emailVerificationCodes.Remove(userEmail);
                        verifiedEmail = userEmail;
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }

        public static class PhoneVerification
        {
            public static async Task<string> SendVerificationCode(string userPhoneNumber)
            {
                string verificationCode = PinCodeGenerator.GeneratePinCode();
                phoneVerificationCodes[userPhoneNumber] = verificationCode;

                await SendCode.SendPhoneCodeAsync(userPhoneNumber, verificationCode);

                return userPhoneNumber;
            }

            public static bool VerifyCode(string userPhoneNumber, string code, out string verifiedPhone)
            {
                verifiedPhone = null;

                if (phoneVerificationCodes.TryGetValue(userPhoneNumber, out string storedCode))
                {
                    if (string.Equals(storedCode, code, StringComparison.OrdinalIgnoreCase))
                    {
                        phoneVerificationCodes.Remove(userPhoneNumber);
                        verifiedPhone = userPhoneNumber;
                        return true;
                    }
                    return false;
                }
                return false;
            }
        }
        public static class DocumentVerification
        {

            public static string NormalizeDocument(string document)
            {
                return RemoveNonNumericCharacters(document);
            }

            public static bool IsValidDocument(string document)
            {
                string normalizedDocument = NormalizeDocument(document);

                if (normalizedDocument.Length != 11)
                    return false;

                int[] digits = new int[11];
                for (int i = 0; i < 11; i++)
                {
                    if (!int.TryParse(normalizedDocument[i].ToString(), out digits[i]))
                        return false;
                }

                int sum1 = 0, sum2 = 0;
                for (int i = 0; i < 9; i++)
                {
                    sum1 += digits[i] * (10 - i);
                    sum2 += digits[i] * (11 - i);
                }

                int remainder1 = sum1 % 11;
                int remainder2 = sum2 % 11;
                if (remainder1 < 2)
                    remainder1 = 0;
                else
                    remainder1 = 11 - remainder1;

                if (remainder2 < 2)
                    remainder2 = 0;
                else
                    remainder2 = 11 - remainder2;

                return digits[9] == remainder1 && digits[10] == remainder2;
            }

            private static string RemoveNonNumericCharacters(string input)
            {
                return Regex.Replace(input, @"[^0-9]", "");
            }
        }

        // Outras implementações de verificação já existentes...
    }
}

    