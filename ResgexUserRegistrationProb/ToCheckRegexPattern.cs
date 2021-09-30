using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXRegularExpressionsAndPattern
{
    public class ToCheckRegexPattern
    {
        /// <summary>
        /// Function to check First name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        /// <returns></returns>
        public static bool validFirstName(string fName)
        {
            string fNamePattern = @"^[A-Z][a-z]{2,}";
            if (fName == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Invalid First name of the user");
            }
            //if first name pattern is match
            if (Regex.IsMatch(fName, fNamePattern))
            {
                Console.WriteLine("First name of the user is : Valid");
                return true;
            }
            //if first name pattern is not match
            else
            {
                Console.WriteLine("First name of the user is : Invalid");
                return false;
            }
        }
        /// <summary>
        /// Function to check Last name is valid or not
        /// </summary>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static bool validLastName(string lName)
        {
            Console.WriteLine("\n***************************************************************************\n");
            string lNamePattern = @"^[A-Z][a-z]{2,}";
            if (lName == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Invalid Last name of the user");
            }
            if (Regex.IsMatch(lName, lNamePattern))
            {
                Console.WriteLine("Last name of the user is : Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Last name of the user is : Invalid");
                return false;
            }
        }
        /// <summary>
        /// Function to check Email-Id is valid or not
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public static bool validEmailID(string emailId)
        {
            Console.WriteLine("\n***************************************************************************\n");
            string emailIdPattern = "^[a-z][a-z 0-9]{2,}([.][A-Za-z]+)?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
            if (emailId == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Invalid Email-Id of the user");
            }
            if (Regex.IsMatch(emailId, emailIdPattern))
            {
                Console.WriteLine("Email-Id of the user is : Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Email-Id of the user is : Invalid");
                return false;
            }
        }
        /// <summary>
        /// Function to check Mobile Number is valid or not
        /// </summary>
        /// <param name="mobileNumber"></param>
        /// <returns></returns>
        public static bool validMobileNumber(string mobileNumber)
        {
            Console.WriteLine("\n***************************************************************************\n");
            string mobileNumberdPattern = "^[9][1][ ][6-9][0-9]{9}$";
            if (mobileNumber == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Invalid Mobile Nummber of the user");
            }
            if (Regex.IsMatch(mobileNumber, mobileNumberdPattern))
            {
                Console.WriteLine("Mobile Nubmber of the user is : Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Mobile Nummber of the user is : Invalid");
                return false;
            }
        }
        /// <summary>
        /// Function to check Password is valid or not
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool validPassword(string password)
        {
            Console.WriteLine("\n***************************************************************************\n");
            string pattern = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d@$!%*?&]{8,}$";
            Regex regex = new Regex(pattern);
            if (password == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Password of the user is : Invalid");
            }
            if (regex.IsMatch(password))
            {
                Console.WriteLine("Password of the user is : Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Password of the user is : Invalid");
                return false;
            }
        }
        /// <summary>
        /// Email is in following pattern
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        public static bool ValidateEmailAllRules(string emailId)
        {
            Console.WriteLine("\n***************************************************************************\n");
            string emailIdPattern = "^[a-z]+[-.+]?([0-9]+)?([a-z]|[0-9])+[@]([0-9]+)?([a-z]+)?[.][a-z]{2,3}([.][a-z]+)?$";
            if (emailId == null)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionsType.MESSAGE, "Email Id of user is : invalid");
            }
            if (Regex.IsMatch(emailId, emailIdPattern))
            {
                Console.WriteLine("Email Id of user is : valid");
                return true;
            }
            else
            {
                Console.WriteLine("Email Id of user is : invalid");
                return false;
            }
        }
    }
}