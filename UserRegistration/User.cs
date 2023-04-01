using System.Text.RegularExpressions;
namespace UserRegistration
{
    public class User
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public string ValidateFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_REGX))
            {
                return "valid";
            }
            else
            {
                return"Invalid";
            }

        }
    }
}