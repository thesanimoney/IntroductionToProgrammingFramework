using System;

namespace LastDigitPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the number and the last digit
            int n, lastDigit;

            // Read user input for the number
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            // Find the last digit using the modulo operation
            lastDigit = n % 10;

            // Print the last digit
            Console.WriteLine("The last digit of the number is: " + lastDigit);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
