using System;

class Program
{
    static void Main()
    {
        // Using suitable variable types for each value
        sbyte value1 = -100;
        byte value2 = 128;
        short value3 = -3540;
        ushort value4 = 64876;
        long value5 = 2147483648;  // Use long to hold the value
        long value6 = -1141583228;
        long value7 = -1223372036854775808;

        // Printing the values to the console
        Console.WriteLine("Value 1: " + value1);
        Console.WriteLine("Value 2: " + value2);
        Console.WriteLine("Value 3: " + value3);
        Console.WriteLine("Value 4: " + value4);
        Console.WriteLine("Value 5: " + value5);
        Console.WriteLine("Value 6: " + value6);
        Console.WriteLine("Value 7: " + value7);

        Console.ReadLine();
    }
}
