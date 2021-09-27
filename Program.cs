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
            ToCheckRegexPattern.validName();
            Console.WriteLine("\n***************************************************************************\n");
            Console.Write("Enter the Last-Name : ");
            string lName = Console.ReadLine();
            Console.WriteLine("Last name of the user is : " + ToCheckRegexPattern.validName(lName));
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
