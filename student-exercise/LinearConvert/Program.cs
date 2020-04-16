using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int x = 1;
            int y = 2;
            Console.WriteLine("Welcome to Feet/Meters Convertor");
            Console.WriteLine();
            Console.WriteLine("Enter (1) for Feet input or (2) for Meters input.");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered " + userInput);

            if (userInput == x)
            {
                Console.WriteLine("Enter Feet to be converted to Meters");
                double f = Convert.ToDouble(Console.ReadLine());
                double m = f * 0.3048;
                Console.WriteLine(f + " feet is converted to " + m + " meters.");
                Console.WriteLine("Thank you for using Feet/Meters Converter!");

            }
            if (userInput == y)
            {
                Console.WriteLine("Enter Meters to be converted to Feet");
                double m = Convert.ToDouble(Console.ReadLine());
                double f = m * 3.2808399;
                Console.WriteLine(m + " meters is converted to " + f + " feet.");
                Console.WriteLine("Thank you for using Feet/Meters Converter!");
            }
        }
    }
}
