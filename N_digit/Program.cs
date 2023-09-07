using System;

namespace NthDigitPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the number, n, and the n-th digit
            int number, n, nDigit;

            // Read user input for the number and n
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the position of the digit (n): ");
            n = int.Parse(Console.ReadLine());

            // Find the n-th digit using modular division
            int divisor = (int)Math.Pow(10, n - 1);

            if (divisor == 0)
            {
                // If n is out of range (e.g., n = 0 or n > number of digits), print a dash
                Console.WriteLine("The specified position is out of range: -");
            }
            else
            {
                nDigit = (number / divisor) % 10;
                Console.WriteLine($"The {n}-th digit from the right is: {nDigit}");
            }

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
