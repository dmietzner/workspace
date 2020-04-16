using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Capstone.Classes
{
    public class VendingMachineItems
    {

        

        public string Code { get; private set; }

        public string Name { get; private set; }

        public virtual string Message { get; }
        
        public int Quantity { get; set; }

        public decimal Price { get; private set; }

        public string Type { get; private set; }

        public string MakeMessage(string item, string message, decimal cost, decimal balance)
        {
            return $"Dispensing... {item.PadRight(25)} {cost.ToString("C2").PadRight(15)} Balance Remaining: {balance:C2}\n{message}";
        }

        public void Dispense(string item, string message, decimal cost, decimal balance)
        {
            balance -= cost;
            Quantity -= 1;


        }

        public void WriteLog(string fullpath, string feedInput, decimal balance)
        {
            using (StreamWriter sw = new StreamWriter(fullpath, true))
            {
                sw.Write(">" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"));
                sw.WriteLine($" - FEED MONEY: {Convert.ToInt32(feedInput):C2}  {balance:C2}");
            }
        }

        public Dictionary<string, VendingMachineItems> DisplayInventory()
        {
            Dictionary<string, VendingMachineItems> itemsInventory = new Dictionary<string, VendingMachineItems>();
            string directory = Directory.GetCurrentDirectory();
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);
            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineSplit = line.Split("|");
                    foreach (string lines in lineSplit)
                    {
                        if (lineSplit[3] == "Chip")
                        {
                            Chip chip = new Chip();
                            chip.Name = lineSplit[1];
                            chip.Price = Convert.ToDecimal(lineSplit[2]);
                            chip.Quantity = 5;
                            itemsInventory.Add(lineSplit[0], chip);
                            break;
                        }
                        if (lineSplit[3] == "Gum")
                        {
                            Gum gum = new Gum();
                            gum.Name = lineSplit[1];
                            gum.Price = Convert.ToDecimal(lineSplit[2]);
                            gum.Quantity = 5;
                            itemsInventory.Add(lineSplit[0], gum);
                            break;
                        }
                        if (lineSplit[3] == "Drink")
                        {
                            Drink drink = new Drink();
                            drink.Name = lineSplit[1];
                            drink.Price = Convert.ToDecimal(lineSplit[2]);
                            drink.Quantity = 5;
                            itemsInventory.Add(lineSplit[0], drink);
                            break;
                        }
                        if (lineSplit[3] == "Candy")
                        {
                            Candy candy = new Candy();
                            candy.Name = lineSplit[1];
                            candy.Price = Convert.ToDecimal(lineSplit[2]);
                            candy.Quantity = 5;
                            itemsInventory.Add(lineSplit[0], candy);
                            break;
                        }

 

                        

                    }


                }
            }
            return itemsInventory;
        }
    }
}
