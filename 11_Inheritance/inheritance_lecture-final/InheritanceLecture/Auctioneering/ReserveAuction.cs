using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
    {
        public ReserveAuction(Item itemToSell)
        {
            ItemOnAuction = itemToSell;
        }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isCurrentWinningBid = false;

            if(offeredBid.Offer >= ItemOnAuction.ReservePrice)
            {
                isCurrentWinningBid = base.PlaceBid(offeredBid);
                Console.WriteLine("Reserve has been met");
                Console.WriteLine();
            } else
            {
                allBids.Add(offeredBid);
                Console.WriteLine("Reserve has not been met " + offeredBid.Bidder);
            }
            return isCurrentWinningBid;
        }
    }
}
