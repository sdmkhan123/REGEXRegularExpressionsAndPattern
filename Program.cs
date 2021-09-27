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
            Console.WriteLine("First name of the user is : " + ToCheckRegexPattern.validName(fName));
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
