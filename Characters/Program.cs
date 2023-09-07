using System;

namespace VariableAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigning string values to variables
            string universityName = "Software University";
            string programmingMessage = "I love programming";

            // Assigning character values to variables
            char charB = 'B';
            char charY = 'y';
            char charE = 'e';

            // Displaying the values of the variables
            Console.WriteLine("University Name: " + universityName);
            Console.WriteLine("Character B: " + charB);
            Console.WriteLine("Character Y: " + charY);
            Console.WriteLine("Character E: " + charE);
            Console.WriteLine("Programming Message: " + programmingMessage);

            // Pause to keep the console window open
            Console.ReadLine();
        }
    }
}