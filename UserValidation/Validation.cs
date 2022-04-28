using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserValidation
{
    public class Validation
    {
        private string FIRST_NAME = "[A-Z][a-z]{3,}";
        private string LAST_NAME = "[A-Z][a-z]{3,}";
        private string EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";

        private string MOBILE_NUMBER = "^[1-9][0-9][ ][1-9][0-9]{9}$";

        //private string PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 1
        //private string PASSWORD = "^(?=.*[A-Z])[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 2
        //private string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 3
        private string PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$"; // Rule 4
        private string MULTIPLE_EMAIL = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

        List<string> EMAIL_ID = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@1.com",
            "abc@1.com"
        };

        //First Name Validate
        public bool FirstNameValidate(string firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME);
        }

        //Last Name Validate
        public bool LastNameValidate(string lastName)
        {
            return Regex.IsMatch(lastName, LAST_NAME);
        }

        public bool EmailValidate(string email)
        {
            return Regex.IsMatch(email, EMAIL);
        }

        public bool MobileNumberValidate(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILE_NUMBER);
        }

        public bool PasswordValidate(string password)
        {
            return Regex.IsMatch(password, PASSWORD);
        }

        public bool MultipleEmailValidate(string email)
        {
            return Regex.IsMatch(email, MULTIPLE_EMAIL);
        }
        public List<string> GetList()
        {
            return EMAIL_ID;
        }

        // Printing Result for all cases
        public string Result(bool result)
        {
            if (result)
            {

                Console.WriteLine("Value is valid!");
                return "Valid";
            }
            else
            {
                Console.WriteLine("Value is invalid!");
                return "Invalild";
            }
        }

    }
}
