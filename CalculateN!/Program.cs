using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the input number and factorial
            int n;
            long factorial = 1; // Use long to handle larger factorials

            // Read user input for the number
            Console.WriteLine("Enter a non-negative integer to calculate its factorial: ");
            n = int.Parse(Console.ReadLine());

            // Check if the input is non-negative
            if (n < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                // Calculate the factorial using a loop
                for (int i = 2; i <= n; i++)
                {
                    factorial *= i;
                }

                // Print the result
                Console.WriteLine($"The factorial of {n} is: {factorial}");
            }

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
