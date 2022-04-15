using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserValidation
{
    class Validation
    {
        private string FIRST_NAME = "[A-Z][a-z]{3,}";
        private string LAST_NAME = "[A-Z][a-z]{3,}";
        private string EMAIL = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        private string MOBILE_NUMBER = "^[1-9][0-9][ ][1-9][0-9]{9}$";
        //private string PASSWORD = "^[a-zA-Z0-9-+_!@#$%^&*()]{8,}"; // Rule 1
        private string PASSWORD = "^(?=.*[A-Z])[a-zA-Z0-9-+_!@#$%^&*()]{8,}";

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
            return Regex.IsMatch(mobileNumber,MOBILE_NUMBER);
        }

        public bool PasswordValidate(string password)
        {
            return Regex.IsMatch(password,PASSWORD);
        }

        // Printing Result for all cases
        public void Result(bool result)
        {
            if (result)
                Console.WriteLine("Value is valid!");
            else
                Console.WriteLine("Value is invalid!");
        }

    }
}
