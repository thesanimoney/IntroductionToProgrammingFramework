using System;

namespace DivisibilityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the number and result
            int n;
            bool result;

            // Test cases
            int[] values = { 121, 1263, 26, 23, 81, 1287 };

            // Loop through the test cases and check divisibility
            foreach (int value in values)
            {
                n = value;

                // Check if the number is divisible by 9, 11, or 13
                result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);

                // Print the result for each test case
                Console.WriteLine($"{n} is divisible by 9, 11, or 13: {result}");
            }

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
