using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : VendingMachineItems
    {
        public override string Message
        {
            get
            {
                return "Munch Munch, Yum!";
            }
        }
    }
}
