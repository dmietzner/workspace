using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISellable
    {
        public Chicken() : base("CHICKEN")
        {
            Sound = "BWAK";
        }

        public override string Eat()
        {
            return "Peck peck";
        }

        public decimal GetSalesPrice()
        {
            return 3.99M;
        }

        public override string ToString()
        {
            return "You can buy this chicken for " + GetSalesPrice();
        }

    }
}
