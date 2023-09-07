using System;

namespace SignOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for three numbers and the product
            double a, b, c, product;

            // Read user input for the three numbers
            Console.WriteLine("Enter the first number: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            c = double.Parse(Console.ReadLine());

            // Calculate the product of the three numbers
            product = a * b * c;

            // Determine the sign of the product using if statements
            if (IsNegative(a) || IsNegative(b) || IsNegative(c))
            {
                // If there are 1 or 3 negative numbers, the product is negative
                Console.WriteLine("The sign of the product is: Negative");
            }
            else if (product == 0)
            {
                // If any of the numbers is zero, the product is zero
                Console.WriteLine("The product is: 0");
            }
            else
            {
                // If there are 0 or 2 negative numbers, the product is positive
                Console.WriteLine("The sign of the product is: Positive");
            }

            // Pause to keep the console window open
            Console.ReadLine();
        }

        // Helper method to check if a number is negative
        static bool IsNegative(double num)
        {
            return num < 0;
        }
    }
}
