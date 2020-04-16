using System;

namespace CommandLineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Strings!");

            // Ask the user for a first name
            Console.WriteLine("Please provide your first name. Pretty please.");
            string firstName = Console.ReadLine();
            Console.WriteLine("You entered: " + firstName);

            // Ask for a last name
            Console.WriteLine("Nice. How about a last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName} {lastName}");

            Console.WriteLine("Where do you live?");
            string city = Console.ReadLine();

            // let's work in our favorite loop!
            Console.WriteLine("What message do you want to see over and over and over...?");
            string message = Console.ReadLine();
            Console.WriteLine("How many times?");
            string timesInput = Console.ReadLine();
            int numTimes = int.Parse(timesInput);
            for(int i = 0; i < numTimes; i++)
            {
                Console.WriteLine(message);
            }

            // how about a while loop?
            int maxLoop = 10;
            bool isDone = false;
            while(!isDone)
            {
                Console.WriteLine(message + " From While Loop: " + numTimes);
                if(DateTime.Now.Second > 30)
                {
                    isDone = true;
                }
            }

            isDone = false;
            do
            {
                Console.WriteLine(message + " From Do While Loop: " + numTimes);
                if (DateTime.Now.Second > 45)
                {
                    isDone = true;
                }

            } while (!isDone);

        }
    }
}
