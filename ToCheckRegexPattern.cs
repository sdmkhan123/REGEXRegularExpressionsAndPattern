using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXRegularExpressionsAndPattern
{
    public class ToCheckRegexPattern
    {
        /// <summary>
        /// Function to check Last name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static void validFirstName()
        {
            string fNamePattern = @"^[A-Z][a-z]{2,}";
            Console.Write("Enter the Frist-Name : ");
            string fName = Console.ReadLine();
            //if first name pattern is match
            if (Regex.IsMatch(fName, fNamePattern))
            {
                Console.WriteLine("First name of the user is : Valid");
            }
            //if first name pattern is not match
            else
            {
                Console.WriteLine("First name of the user is : Invalid");
            }
        }
        /// <summary>
        /// Function to check Last name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static void validLastName()
        {
            Console.WriteLine("\n***************************************************************************\n");
            string lNamePattern = @"^[A-Z][a-z]{2,}";
            Console.Write("Enter the Last-Name : ");
            string lName = Console.ReadLine();
            if (Regex.IsMatch(lName, lNamePattern))
            {
                Console.WriteLine("Last name of the user is : Valid");
            }
            else
            {
                Console.WriteLine("Last name of the user is : Invalid");
            }
        }
        /// <summary>
        ///  Function to check Email-Id is valid or not
        /// </summary>
        public static void validEmailID()
        {
            Console.WriteLine("\n***************************************************************************\n");
            string emailIdPattern = "^[a-z][a-z 0-9]{2,}([.][A-Za-z]+)?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
            Console.Write("Enter the email-Id : ");
            string emailId = Console.ReadLine();
            if (Regex.IsMatch(emailId, emailIdPattern))
            {
                Console.WriteLine("Email-Id of the user is : Valid");
            }
            else
            {
                Console.WriteLine("Email-Id of the user is : Invalid");
            }
        }
        /// <summary>
        /// Function to check Mobile Number is valid or not
        /// </summary>
        public static void validMobileNumber()
        {
            Console.WriteLine("\n***************************************************************************\n");
            string mobileNumberdPattern = "^[9][1][ ][6-9][0-9]{9}$";
            Console.Write("Enter the Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            if (Regex.IsMatch(mobileNumber, mobileNumberdPattern))
            {
                Console.WriteLine("Mobile Nubmber of the user is : Valid");
            }
            else
            {
                Console.WriteLine("Mobile Nummber of the user is : Invalid");
            }
        }
        /// <summary>
        /// Function to check Password is valid or not
        /// </summary>
        public void validPassword()
        {
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Password : ");
            string password = Console.ReadLine();
            string passpattern = @"^[0-9a-zA-Z]{8,}$";
            Regex reg = new Regex(passpattern);
            if (password.Length >= 8 && toCheckNumOfUpperCase(password) >= 1 && ToCheckNumeric(password) >= 1)
            {
                Console.WriteLine("Password of the user is : Valid");
            }
            else
            {

                Console.WriteLine("Password of the user is : Invalid");
            }
        }
        /// <summary>
        /// To chech Upper case char atleast one
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        private int toCheckNumOfUpperCase(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsUpper(ch))
                {
                    num++;
                }
            }
            return num;
        }
        /// <summary>
        /// To chech atleast one Numeric value
        /// </summary>
        /// <param name="pass"></param>
        /// <returns></returns>
        private int ToCheckNumeric(string pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch))
                {
                    num++;
                }
            }
            return num;
        }
    }
}