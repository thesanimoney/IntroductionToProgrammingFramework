using System;

namespace TrapezoidAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for base sides and height
            double a, b, h, area;

            // Read user input for the base sides and height
            Console.WriteLine("Enter the length of base side 'a': ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of base side 'b': ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height 'h': ");
            h = double.Parse(Console.ReadLine());

            // Calculate the area of the trapezoid
            area = 0.5 * (a + b) * h;

            // Print the result
            Console.WriteLine("The area of the trapezoid is: " + area);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
