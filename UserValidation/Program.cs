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
            bool Email = validate.EmailValidate(email);
            validate.Result(Email);
            
            //Validating Mobile Number
            Console.WriteLine("Enter the mobile number : ");
            string mobile = Console.ReadLine();
            bool MobileNo = validate.MobileNumberValidate(mobile);
            validate.Result(MobileNo);
            
            //Validating Password
            Console.WriteLine("Enter the password : ");
            string password = Console.ReadLine();
            bool Password = validate.PasswordValidate(password);
            validate.Result(Password);



            Console.ReadLine();
        }
    }
}
