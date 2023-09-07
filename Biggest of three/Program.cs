using System;

namespace BiggestNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for three numbers
            int a, b, c;

            // Read user input for the three numbers
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            c = int.Parse(Console.ReadLine());

            // Find the biggest number using conditional if statements
            int biggestNumber = a; // Assume the first number is the biggest

            if (b > biggestNumber)
            {
                biggestNumber = b; // Update if the second number is bigger
            }

            if (c > biggestNumber)
            {
                biggestNumber = c; // Update if the third number is bigger
            }

            // Print the result
            Console.WriteLine("The biggest number is: " + biggestNumber);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
