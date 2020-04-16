using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class Bid
    {
        /// <summary>
        /// The name of the bidder
        /// </summary>
        public string Bidder { get; }
        /// <summary>
        /// The bid amount
        /// </summary>
        public decimal Offer { get; }
        /// <summary>
        /// Constructor for the Bid object. Each bid requires a bidder name and amount
        /// </summary>
        /// <param name="bidder">Who is bidding</param>
        /// <param name="offer">How mush is bid</param>
        public Bid(string bidder, decimal offer)
        {
            Bidder = bidder;
            Offer = offer;
        }
    }
}
