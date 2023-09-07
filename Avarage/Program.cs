using System;

{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for three numbers and the average
            int a, b, c;
            double average;

            // Read user input for the three numbers
            Console.WriteLine("Enter the first number: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            c = int.Parse(Console.ReadLine());

            // Calculate the average
            average = (a + b + c) / 3.0;

            // Print the result
            Console.WriteLine("Average: " + average);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
