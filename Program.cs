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
            ToCheckRegexPattern.validFirstName();
            ToCheckRegexPattern.validLastName();
            ToCheckRegexPattern.validEmailID();
            ToCheckRegexPattern.validMobileNumber();
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
