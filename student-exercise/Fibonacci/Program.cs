using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibinacci");
            int fib = int.Parse(Console.ReadLine());

            for (int i = 1; i >= 10; i++)
            {
                Console.WriteLine( fib);
            }
        }
    }
}
