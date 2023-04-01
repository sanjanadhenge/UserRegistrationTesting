using System.Text.RegularExpressions;
namespace UserRegistration
{
    public class User
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public static string Mail_ID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
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
        public string ValidateLastName(string firstName)
        {
            if (Regex.IsMatch(firstName, NAME_REGX))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }
        }
      
    }
}