using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pitchfork : ISingable, ISellable
    {
        public string Name { get { return "Pitchfork"; } }

        public string Sound { get { return "OUCH"; } }

        public decimal GetSalesPrice()
        {
            return 6.55M;
        }

        public string MakeSoundOnce()
        {
            return Sound;
        }

        public string MakeSoundTwice()
        {
            return Sound + " " + Sound;
        }

        public override string ToString()
        {
            return "You can buy this pitchfork for " + GetSalesPrice();
        }
    }
}
