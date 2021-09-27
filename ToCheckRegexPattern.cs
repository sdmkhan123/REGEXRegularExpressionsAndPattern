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
        /// Function to check name is valid or not
        /// </summary>
        /// <param name="fName"></param>
        public static void validName()
        {
            string fNamePattern = @"^[A-Z]{1}[a-z]{3,}";
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
    }
}