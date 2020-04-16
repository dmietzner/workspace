using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Capstone.Classes
{
    public class Menus

    {
        VendingMachineItems vendingMachine = new VendingMachineItems();
        public void DisplayMenu(string userInput)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            VendingMachineItems vendingMachine = new VendingMachineItems();
            Dictionary<string, VendingMachineItems> items = vendingMachine.DisplayInventory();
            string directory = Directory.GetCurrentDirectory();
            string fullpath = Path.Combine(directory, "log.txt");
            string vendingMachineMessage = "";
            bool purchasing = false;
            bool notEnoughMoneys = false;
            bool invalidItemCode = false;
            bool outOfStock = false;
            bool validMoneyAmount = true;

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("| ~ * - Vendo-Matic 800 - * ~ |");
                Console.WriteLine("|       1) Display Items      |");
                Console.WriteLine("|         2) Purchase         |");
                Console.WriteLine("|           3) Exit           |");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("|                             |");
                Console.WriteLine("|                       $$    |");
                Console.WriteLine("|                      [--]   |");
                Console.WriteLine("|                             |");
                Console.WriteLine("| |__| |__| |__| |__| [A] [1] |");
                Console.WriteLine("| |__| |__| |__| |__| [B] [2] |");
                Console.WriteLine("| |__| |__| |__| |__| [C] [3] |");
                Console.WriteLine("| |__| |__| |__| |__| [D] [4] |");
                Console.WriteLine("|                             |");
                Console.WriteLine("|                             |");
                Console.WriteLine("|                             |");
                Console.WriteLine("|   [_____________________]   |");
                Console.WriteLine("-------------------------------");
                userInput = Console.ReadLine();
                decimal balance = 0.0M;

                while (userInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Code       Item Description         Price          Quantity");
                    Console.WriteLine();
                    foreach (KeyValuePair<string, VendingMachineItems> keyValuePair in items)
                    {
                        string code = keyValuePair.Key;
                        string name = keyValuePair.Value.Name;
                        decimal price = keyValuePair.Value.Price;
                        int quantity = keyValuePair.Value.Quantity;
                        Console.WriteLine(code.PadRight(10) + " " + name.PadRight(25) + price.ToString("C2").PadRight(15) + quantity);
                    }
                    Console.WriteLine();
                    userInput = "0";

                }
                while (userInput == "2")

                {
                    Console.Clear();
                    string purchaseInput = "";
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("| ~ * - Vendo-Matic 800 - * ~ |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("|        1) Feed Money  $$    |");
                    Console.WriteLine("|                      [--]   |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("| |__| |__| |__| |__| [A] [1] |");
                    Console.WriteLine("| |__| |__| |__| |__| [B] [2] |");
                    Console.WriteLine("| |__| |__| |__| |__| [C] [3] |");
                    Console.WriteLine("| |__| |__| |__| |__| [D] [4] |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("|      2) Select Product      |");
                    Console.WriteLine("|                             |");
                    Console.WriteLine("|   [3)_Finish_Transaction]   |");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Current money provided: {balance:C2}");
                    if(purchasing)
                    { 
                    Console.WriteLine(vendingMachineMessage);

                    }
                    if(notEnoughMoneys)
                    {
                        Console.WriteLine("Not enough money!");
                    }
                    if(invalidItemCode)
                    {
                        Console.WriteLine("Invalid item code!");
                    }
                    if(outOfStock)
                    {
                        Console.WriteLine("Out of stock!");
                    }
                    if(!validMoneyAmount)
                    {
                        Console.WriteLine("Invalid money amount");
                    }

                    purchaseInput = Console.ReadLine();
                    while (purchaseInput == "1")
                    {
                        
                        Console.WriteLine("Please feed money into the vending machine in whole dollar amounts ($1/$2/$5/$10)");
                        string feedInput = Console.ReadLine();
                        if (feedInput == "$1" || feedInput == "1" || feedInput == "$1.00")
                        {
                            balance += 1.00M;
                            vendingMachine.WriteLog(fullpath, feedInput, balance);
                            purchasing = false;
                            notEnoughMoneys = false;
                            invalidItemCode = false;
                            outOfStock = false;
                            validMoneyAmount = true;

                        }
                        else if (feedInput == "2" || feedInput == "$2" || feedInput == "$2.00")
                        {
                            balance += 2.00M;
                            vendingMachine.WriteLog(fullpath, feedInput, balance);
                            purchasing = false;
                            notEnoughMoneys = false;
                            invalidItemCode = false;
                            outOfStock = false;
                            validMoneyAmount = true;


                        }
                        else if (feedInput == "5" || feedInput == "$5" || feedInput == "$5.00")
                        {
                            balance += 5.00M;
                            vendingMachine.WriteLog(fullpath, feedInput, balance);
                            purchasing = false;
                            notEnoughMoneys = false;
                            invalidItemCode = false;
                            outOfStock = false;
                            validMoneyAmount = true;

                        }
                        else if (feedInput == "10" || feedInput == "$10" || feedInput == "$10.00")
                        {
                            balance += 10.00M;
                            vendingMachine.WriteLog(fullpath, feedInput, balance);
                            purchasing = false;
                            notEnoughMoneys = false;
                            invalidItemCode = false;
                            outOfStock = false;
                            validMoneyAmount = true;

                        }
                        else
                        {
                            validMoneyAmount = false;
                        }
                        Console.WriteLine($"Your current balance is {balance:C2}");
                        



                        purchaseInput = "0";
                    }
                    while (purchaseInput == "2")
                    {
                        Console.WriteLine("Please select item:");
                        Console.WriteLine();
                        Console.WriteLine("Code       Item Description         Price          Quantity");
                        Console.WriteLine();
                        foreach (KeyValuePair<string, VendingMachineItems> keyValuePair in items)
                        {
                            string code = keyValuePair.Key;
                            string name = keyValuePair.Value.Name;
                            decimal price = keyValuePair.Value.Price;
                            int quantity = keyValuePair.Value.Quantity;

                            Console.WriteLine(code.PadRight(10) + " " + name.PadRight(25) + price.ToString("C2").PadRight(15) + quantity);
                        }
                        string itemSelect = Console.ReadLine();
                        if (items.ContainsKey(itemSelect.ToUpper()))
                        {
                            foreach (KeyValuePair<string, VendingMachineItems> keyValuePair in items)
                            {
                                string code = keyValuePair.Key;
                                string name = keyValuePair.Value.Name;
                                decimal price = keyValuePair.Value.Price;
                                int quantity = keyValuePair.Value.Quantity;
                                string message = keyValuePair.Value.Message;
                                if (itemSelect == code)
                                {
                                    if (balance > price && quantity > 0)
                                    {
                                        using (StreamWriter sw = new StreamWriter(fullpath, true))
                                        {
                                            sw.Write(">" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                                            sw.WriteLine($" - {keyValuePair.Value.Name} {code} {balance:C2} {balance -= keyValuePair.Value.Price:C2}");
                                        }



                                        vendingMachine.Dispense(name, message, price, balance);
                                        vendingMachineMessage = vendingMachine.MakeMessage(name, message, price, balance);
                                        keyValuePair.Value.Quantity -= 1;
                                        purchasing = true;
                                        notEnoughMoneys = false;
                                        invalidItemCode = false;
                                        outOfStock = false;
                                        validMoneyAmount = true;
                                    }
                                    else if (balance < price)
                                    {

                                        notEnoughMoneys = true;
                                        purchasing = false;
                                        invalidItemCode = false;
                                        outOfStock = false;
                                        validMoneyAmount = true;
                                    }
                                    else if (quantity <= 0)
                                    {
                                        notEnoughMoneys = false;
                                        purchasing = false;
                                        invalidItemCode = false;
                                        outOfStock = true;
                                        validMoneyAmount = true;
                                    }
                                }

                            }
                        } else
                        {
                            invalidItemCode = true;
                            notEnoughMoneys = false;
                            purchasing = false;
                            outOfStock = false;
                            validMoneyAmount = true;
                        }
                        purchaseInput = "0";



                    }
                    while (purchaseInput == "3")
                    {
                        decimal emptyBalance = 0.00M;
                        Console.Clear();
                        using(StreamWriter sw = new StreamWriter(fullpath, true))
                        {
                            sw.Write(">" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                            sw.WriteLine($" - GIVE CHANGE: {balance:C2}  {emptyBalance:C2}");
                        }
                        string change = "";
                        decimal quarters = 0;
                        decimal nickels = 0;
                        decimal dimes = 0;
                        quarters = balance / 0.25M;
                        balance = balance % 0.25M;
                        dimes = balance / 0.10M;
                        balance = balance % 0.10M;
                        nickels = balance / 0.05M;
                        balance = balance % 0.05M;
                        Console.WriteLine($"Balance = {balance:C2}");
                        Console.WriteLine($"Dispensing {Convert.ToInt32(Math.Floor(quarters))} quarters, {Convert.ToInt32(Math.Floor(dimes))} dimes, and {Convert.ToInt32(Math.Floor(nickels))} nickels...");
                        Console.WriteLine();
                      
                        userInput = "0";
                        break;
                    }
                    while (userInput == "3")
                    {
                        Environment.Exit(0);
                    }
                } 
            } while (userInput == "0");
        }
    }

}
