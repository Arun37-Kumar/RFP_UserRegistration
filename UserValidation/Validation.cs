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
        //CONSTANT DECLARATIONS
        private string FIRST_NAME = "[A-Z][a-z]{3,}";
        private string LAST_NAME = "[A-Z][a-z]{3,}";
        private string EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";

        private string MOBILE_NUMBER = "^[1-9][0-9][ ][1-9][0-9]{9}$";

        //private string PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 1
        //private string PASSWORD = "^(?=.*[A-Z])[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 2
        //private string PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 3
        private string PASSWORD = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&*+-.]*[!@#$%&*+-.][^!@#$%&*+-.]*$)[\\S]{8,}$"; // Rule 4
        private string MULTIPLE_EMAIL = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

        //MULTIPLE EMAIL
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
            if (firstName.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            }
            else
            {

                Func<string, bool> Validate = (f) => Regex.IsMatch(f, FIRST_NAME);
                bool res = Validate(firstName);
                return res;

            }
        }

        //Last Name Validate
        public bool LastNameValidate(string lastName)
        {
            if (lastName.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            }
            else
            {
                Func<string, bool> Validate = (f) => Regex.IsMatch(f, LAST_NAME);
                bool res = Validate(lastName);
                return res;
            }

        }

        public bool EmailValidate(string email)
        {
            if (email.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            }
            else
            {
                Func<string, bool> Validate = (f) => Regex.IsMatch(f, EMAIL);
                bool res = Validate(email);
                return res;
            }
        }

        public bool MobileNumberValidate(string mobileNumber)
        {
            if (mobileNumber.Equals(""))
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            }
            else
            {
                Func<string, bool> Validate = (f) => Regex.IsMatch(f, MOBILE_NUMBER);
                bool res = Validate(mobileNumber);
                return res;
            }
        }

        public bool PasswordValidate(string password)
        {
            if (password.Equals(""))
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            else
                return Regex.IsMatch(password, PASSWORD);
        }

        public bool MultipleEmailValidate(string email)
        {
            if (email.Equals(""))
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "Message cannot be empty");
            else
            {
                Func<string, bool> Validate = (multipleEmail) => Regex.IsMatch(multipleEmail, MULTIPLE_EMAIL);
                bool res = Validate(email);
                return res;
            }
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
