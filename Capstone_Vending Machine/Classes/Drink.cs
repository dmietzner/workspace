using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drink : VendingMachineItems 
    {
        public override string Message
        {
            get
            {
                return "Glug Glug, Yum!";
            }
        }
    }
}
