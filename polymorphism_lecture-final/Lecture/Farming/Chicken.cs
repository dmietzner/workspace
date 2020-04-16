using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISellable
    {
        public Chicken() : base("CHICKEN")
        {

        }

        public decimal GetSalesPrice()
        {
            return 3.99M;
        }

        public override string MakeSoundOnce()
        {
            return "BWAK";
        }
        public override string MakeSoundTwice()
        {
            return "BWAK BWAK";
        }

        public override string ToString()
        {
            return "You can buy this chicken for " + GetSalesPrice();
        }

    }
}
