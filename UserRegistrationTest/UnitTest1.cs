using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserValidation;


namespace UserRegistrationTest
{
    [TestClass]
    public class UserRegistrationTest
    {

       [TestCategory("First Name Validation")]
       [DataRow("Arun","True")]
       [DataRow("ARUN","False")]
       [DataRow("","False")]
       [DataRow(null,"True")]
       [TestMethod]
       public void FirstName(string input,string expected)
        {
            try
            {
                UserValidation.Validation val = new Validation();
                bool act = val.FirstNameValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Last Name Validation")]
        [DataRow("Kumar", "True")]
        [DataRow("KUMAR", "False")]
        [DataRow("", "False")]
        [DataRow(null, "True")]
        [TestMethod]
        public void LastName(string input, string expected)
        {
            try
            {
                UserValidation.Validation val = new Validation();
                bool act = val.LastNameValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Email Validation")]
        [DataRow("abc@yahoo.com", "True")]
        [DataRow("KUMAR", "False")]
        [DataRow("", "False")]
        [TestMethod]
        public void Email(string input, string expected)
        {
            try
            {
                UserValidation.Validation validate = new Validation();
                bool act = validate.EmailValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Mobile Number Validation ")]
        [DataRow("91 9876543210", "True")]
        [DataRow("456789123", "False")]
        [DataRow("", "False")]
        [TestMethod]
        public void MobileNumber(string input, string expected)
        {
            try
            {
                UserValidation.Validation validate = new Validation();
                bool act = validate.MobileNumberValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Password Validation ")]
        [DataRow("abc@123.34", "True")]
        [DataRow("456789123", "False")]
        [DataRow("", "False")]
        [TestMethod]
        public void Password(string input, string expected)
        {
            try
            {
                UserValidation.Validation validate = new Validation();
                bool act = validate.PasswordValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Multiple Email Validation ")]
        [DataRow("abc@yahoo.com", "True")]
        [DataRow("abc-100@yahoo.com", "True")]
        [DataRow("abc111@abc.com", "True")]
        [DataRow("abc-100@abc.net", "True")]
        [DataRow("abc.100@abc.com.au", "True")]
        [DataRow("abc@1.com", "True")]
        [DataRow("abc@1.com", "True")]
        [DataRow("456789123", "False")]
        [DataRow("abc@1.com", "True")]
        [TestMethod]
        public void MultipleEmail(string input, string expected)
        {
            try
            {
                UserValidation.Validation validate = new Validation();
                bool act = validate.MultipleEmailValidate(input);
                string actual = act.ToString();
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }


    }
}
