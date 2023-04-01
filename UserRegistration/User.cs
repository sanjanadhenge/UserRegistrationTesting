using System.Text.RegularExpressions;
namespace UserRegistration
{
    public class User
    {
        public static string NAME_REGX = "^[A-Z]{1}[a-z]{2,}$";
        public static string Mail_ID = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]+[@]{1}[a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string MOBILENUMBER = "^[6-9]{1}[0-9]{9}$";
        // public static string Mail_ID = "^[a-zA-Z]+[.+_]{1}[a-zA-Z]";
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
        public string ValidateLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME_REGX))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }
        }
        public string ValidateMailID(string mail)
        {
            if (Regex.IsMatch((string)mail, Mail_ID))
            {
                return "valid";
            }
            else
            {
                return "Invalid";
            }

        }

        public string ValidateMobile(string Mobile)
        {
            if (Regex.IsMatch((string)Mobile, MOBILENUMBER))
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