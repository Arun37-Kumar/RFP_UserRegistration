using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem !");

            //Creating Object
            Validation validate = new Validation();

            Console.WriteLine("Enter the First Name : ");
            string firstname = Console.ReadLine();
            bool fName = validate.FirstNameValidate(firstname);
            validate.Result(fName);

            Console.ReadLine();
        }
    }
}
