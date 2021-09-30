using System;

namespace REGEXRegularExpressionsAndPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Welcome to REGEX Regular Expressions & Pattern");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Frist-Name : ");
            string fName = Console.ReadLine();
            ToCheckRegexPattern.validFirstName(fName);
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Last-Name : ");
            string lName = Console.ReadLine();
            ToCheckRegexPattern.validLastName(lName);
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the email-Id : ");
            string emailId = Console.ReadLine();
            ToCheckRegexPattern.validEmailID(emailId);
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Mobile Number : ");
            string mobileNumber = Console.ReadLine();
            ToCheckRegexPattern.validMobileNumber(mobileNumber);
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Password : ");
            string password = Console.ReadLine();
            ToCheckRegexPattern.validPassword(password);
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Email Id of user : ");
            string allEmailId = Console.ReadLine();
            ToCheckRegexPattern.ValidateEmailAllRules(allEmailId);
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
