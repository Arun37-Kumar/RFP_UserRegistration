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

            //Validating First Name
            Console.WriteLine("Enter the First Name : ");
            string firstname = Console.ReadLine();
            bool fName = validate.FirstNameValidate(firstname);
            validate.Result(fName);

            // Validating Last Name
            Console.WriteLine("Enter the Last Name : ");
            string lastName = Console.ReadLine();
            bool lName = validate.FirstNameValidate(lastName);
            validate.Result(lName);

            //Validating Email
            Console.WriteLine("Enter the email : ");
            string email = Console.ReadLine();
            bool Email = validate.FirstNameValidate(email);
            validate.Result(Email);

            Console.ReadLine();
        }
    }
}
