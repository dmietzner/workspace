using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class Item
    {
        /// <summary>
        /// The description of the item
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Name of the donor of the item
        /// </summary>
        public string Donor { get; }
        /// <summary>
        /// A starting price if one is specified
        /// </summary>
        public decimal StartPrice { get; set; }

        /// <summary>
        /// Sets and gets the reserve price
        /// </summary>
        public decimal ReservePrice { get; private set; }

        public Item(string description, string donor)
        {
            Description = description;
            Donor = donor;
        }
        public Item(string description, string donor,decimal reservePrice)
        {
            Description = description;
            Donor = donor;
            ReservePrice = reservePrice;
        }
    }
}
