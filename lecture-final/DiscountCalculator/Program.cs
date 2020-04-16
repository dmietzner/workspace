using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Discount Calculator");
            Console.WriteLine();
            // Prompt the user for a discount price
            // The answer needs to be saved as a double
            Console.WriteLine("Enter a discount percentage in the form of 50 for 50%. (please no % sign)");
            double discount = double.Parse(Console.ReadLine());
            // adjust discount for math purposes
            discount = discount / 100;
            // Prompt the user for a series of prices
            Console.WriteLine("Please provide a series of prices separated by spaces");
            string prices = Console.ReadLine();

            // put all the price into an array
            string[] priceArray = prices.Split(' ');

            // Loops through our array
            for (int i = 0; i < priceArray.Length; i++)
            {
                // Read the individual value as a decimal
                decimal originalPrice = decimal.Parse(priceArray[i]);

                // Cast the discount value to a decimal to allow the calculation
                decimal amountOff = originalPrice * (decimal)discount;

                // Calculate the sale price
                decimal salePrice = originalPrice - amountOff;

                Console.WriteLine($"Original Price: {originalPrice:C2} | Sale Price: {salePrice:C2} | Amount Savings: {amountOff:C2}");

            }
        }
    }
}
