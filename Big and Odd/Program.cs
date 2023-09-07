using System;

namespace NumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the number and result
            int n;
            bool result;

            // Read user input for the number
            Console.WriteLine("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            // Check if the number is greater than 20 and odd
            result = (n > 20) && (n % 2 == 1);

            // Print the result
            Console.WriteLine("Is the number greater than 20 and odd? " + result);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
