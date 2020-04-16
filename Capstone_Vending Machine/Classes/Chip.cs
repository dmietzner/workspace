using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chip : VendingMachineItems
    {
        public override string Message
        {
            get
            {
                return "Crunch Crunch, Yum!";
            }
        }
    }
}
