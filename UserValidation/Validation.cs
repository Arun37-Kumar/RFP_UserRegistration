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

        public bool FirstNameValidate(string firstName)
        {
            return Regex.IsMatch(firstName, FIRST_NAME);
        }

        public void Result(bool result)
        {
            if (result)
                Console.WriteLine("Value is valid!");
            else
                Console.WriteLine("Value is invalid!");
        }

    }
}
