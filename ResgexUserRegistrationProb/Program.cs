using System;

namespace REGEXRegularExpressionsAndPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ToCheckRegexPattern toCheckRegexPattern = new ToCheckRegexPattern();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Welcome to REGEX Regular Expressions & Pattern");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("\n***************************************************************************\n");
            ToCheckRegexPattern.validFirstName();
            ToCheckRegexPattern.validLastName();
            ToCheckRegexPattern.validEmailID();
            ToCheckRegexPattern.validMobileNumber();
            toCheckRegexPattern.validPassword();
            ToCheckRegexPattern.ValidateEmailAllRules();
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
