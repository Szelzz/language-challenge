using System;
using System.Linq;

namespace FindPIToTheNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string userDigits;
            int digits;
            do
            {
                Console.WriteLine("How many of PI digits would you like? (max 15)");
                userDigits = Console.ReadLine();
            } while (!int.TryParse(userDigits, out digits) || digits < 0 || digits > 15);
            digits--; // first digit
            Console.WriteLine(RoundDown(Math.PI, digits));
        }

        private static double RoundDown(double d, double decimals)
        {
            var pow = Math.Pow(10, decimals);

            return Math.Truncate(Math.PI * pow) / pow;
        }
    }
}
