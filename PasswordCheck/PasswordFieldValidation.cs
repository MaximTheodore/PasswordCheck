using System.Text.RegularExpressions;

namespace PasswordCheck
{
    public class PasswordFieldValidation
    {
        public static int PasswordFieldCheck(string password)
        {
            int ball = 0;

            string[] pattern = {@"\d", "[a-z]", "[A-Z]", 
                @"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]" };

            if (Regex.IsMatch(password, pattern[0])) ball++;
            if (Regex.IsMatch(password, pattern[1])) ball++;
            if (Regex.IsMatch(password, pattern[2])) ball++;
            if (Regex.IsMatch(password, pattern[3])) ball++;
            if (password.Length > 7) ball++;


            return ball;
        }
    }
}