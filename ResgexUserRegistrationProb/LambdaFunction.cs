using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXRegularExpressionsAndPattern
{
    public class LambdaFunction
    {
        /// <summary>
        /// User data validation
        /// </summary>
        public static void lambdaValidateFun()
        {
            //create a array of string for Regex Pattern
            string[] RegexPattern = new string[6];
            //Pattern for first name atleast 3 char
            RegexPattern[0] = @"^[A-Z][a-z]{2,}";
            //Pattern for last name atleast 3 char
            RegexPattern[1] = @"^[A-Z][a-z]{2,}";
            //Patter for a given email id
            RegexPattern[2] = @"^[a-z][a-z 0-9]{2,}([.][A-Za-z]+)?[@][a-z]+[.][a-z]{2,3}([.][a-z]{2})?$";
            //Pattern for Mobile number having 2 digit country code and exactly 10 digit mobile num
            RegexPattern[3] = @"^[9][1][ ][6-9][0-9]{9}$";
            //Pattern for Password having atleast 8 char with some condtion
            RegexPattern[4] = @"^(?=.*[A-Z])(?=.*\d)(?=.*\W)[A-Za-z\d@$!%*?&]{8,}$";
            //Pattern for group of sample email id with given condition
            RegexPattern[5] = @"^[a-z]+[-.+]?([0-9]+)?([a-z]|[0-9])+[@]([0-9]+)?([a-z]+)?[.][a-z]{2,3}([.][a-z]+)?$";
            //create a array of string for input given by user
            string[] userData = new string[6];
            Console.Write("Enter first name of the user :");
            userData[0] = Console.ReadLine();
            Console.Write("Enter last name of the user :");
            userData[1] = Console.ReadLine();
            Console.Write("Enter  email id of the user : ");
            userData[2] = Console.ReadLine();
            Console.Write("Enter the mobile Number of the user : ");
            userData[3] = Console.ReadLine();
            Console.Write("Enter Password of the user : ");
            userData[4] = Console.ReadLine();
            Console.Write("Enter Sample Email Id of the user : ");
            userData[5] = Console.ReadLine();
            Console.WriteLine("............................");
            for (int i = 0; i < 6; i++)
            {
                Func<string, bool> nameValidater = UserInput => Regex.IsMatch(UserInput, RegexPattern[i]);
                bool result = nameValidater(userData[i]);
                Console.WriteLine(($"{i + 1} {userData[i]} : {result}"));

            }
        }
    }
}
