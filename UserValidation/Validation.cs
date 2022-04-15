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
