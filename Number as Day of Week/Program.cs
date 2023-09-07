using System;

namespace DayOfWeekConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable for the input digit
            int n;

            // Read user input for the digit
            Console.WriteLine("Enter a digit (1-7): ");
            n = int.Parse(Console.ReadLine());

            // Initialize a variable for the day of the week
            string dayOfWeek;

            // Use a switch statement to determine the day of the week
            switch (n)
            {
                case 1:
                    dayOfWeek = "Monday";
                    break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
                default:
                    dayOfWeek = "not valid";
                    break;
            }

            // Print the result
            Console.WriteLine("Day of the week: " + dayOfWeek);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}
