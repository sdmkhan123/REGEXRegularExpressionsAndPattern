using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXRegularExpressionsAndPattern
{
    public class ToCheckRegexPattern
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Function to check Last name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static void validFirstName()
        {
            string fNamePattern = @"^[A-Z]{1}[a-z]{2,}";
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
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Function to check Last name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static void validLastName()
        {
            Console.WriteLine("\n***************************************************************************\n");
            string lNamePattern = @"^[A-Z]{1}[a-z]{2,}";
            Console.Write("Enter the Last-Name : ");
            string lName = Console.ReadLine();
            //if last name pattern is match
            if (Regex.IsMatch(lName, lNamePattern))
            {
                Console.WriteLine("Last name of the user is : Valid");
            }
            //if last name pattern is not match
            else
            {
                Console.WriteLine("Last name of the user is : Invalid");
            }
        }
    }
}