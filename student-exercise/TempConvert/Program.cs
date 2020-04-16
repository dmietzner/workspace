using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            int x = 1;
            int y = 2;
            Console.WriteLine("Welcome to Temp Convertor");
            Console.WriteLine("Enter (1) for Farenheit or (2) for Celsius.");
            userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered " + userInput);

            if (userInput == x)
            {
                Console.WriteLine("Enter F. temp to be converted to C.");
                double tf = Convert.ToDouble(Console.ReadLine());
                double cf = (tf - 32) * 5 / 9;
                Console.WriteLine(tf + "F. is converted to " + cf + " C.");
                Console.WriteLine("Thank you for using Temperature Converter!");

            }
            if (userInput == y)
            {
                Console.WriteLine("Enter C. temp to be converted to F.");
                double cf = Convert.ToDouble(Console.ReadLine());
                double tf = (cf * 1.8) + 32;
                Console.WriteLine(cf + " C. is converted to " + tf + " F.");
                Console.WriteLine("Thank you for using Temperature Converter!");
            }
        
        }
    }
}
