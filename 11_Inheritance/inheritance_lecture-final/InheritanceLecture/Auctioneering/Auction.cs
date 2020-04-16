using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class Auction
    {
        /// <summary>
        /// Represents the current high bid and sets an initial bid of zero
        /// </summary>
        public Bid CurrentHighBid { get; private set; } = new Bid("", 0M);

        /// <summary>
        /// This is a field to hold the history of the bids. Protected allows it to be inherited
        /// </summary>
        protected List<Bid> allBids { get; set; } = new List<Bid>();

        /// <summary>
        /// All placed bids returned as an array
        /// </summary>
        public Bid[] AllBids
        {
            get { return allBids.ToArray(); }
        }

        /// <summary>
        /// What item are we bidding on
        /// </summary>
        public Item ItemOnAuction { get; set; } = new Item("", "");
        
        //public Auction(Item itemToBidOn)
        //{
        //    ItemOnAuction = itemToBidOn;
        //}
        public virtual bool PlaceBid(Bid offeredBid)
        {
            // Print out the bid details
            Console.WriteLine("Placing bid by " + offeredBid.Bidder + " for $" + offeredBid.Offer + " on item " + ItemOnAuction.Description);
            // Record th bid in the log of allBids
            allBids.Add(offeredBid);
            // Check to see if it is higher than the current high bid
            bool isCurrentWinningBid = false;
            if(offeredBid.Offer > CurrentHighBid.Offer)
            {
                // if yes, set offered bid as the current high bid
                CurrentHighBid = offeredBid;
                isCurrentWinningBid = true;
            }

            Console.WriteLine($"Current high bid is {CurrentHighBid.Bidder} for {CurrentHighBid.Offer:C2} on {ItemOnAuction.Description}");
            Console.WriteLine();

            return isCurrentWinningBid;
        }
    }
}
