using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction();
            int numBids = 0;
            do
            {
                Console.WriteLine("Who is bidding?");
                string bidder = Console.ReadLine();
                Console.WriteLine("How much are you bidding?");
                decimal bidAmount = decimal.Parse(Console.ReadLine());
                Bid nextBid = new Bid(bidder, bidAmount);
                generalAuction.PlaceBid(nextBid);
                numBids++;
            } while (numBids < 5);

            for (int i = 0; i < generalAuction.AllBids.Length; i++)
            {
                Console.WriteLine($"{generalAuction.AllBids[i].Bidder} bid {generalAuction.AllBids[i].Offer}");
            }

            Console.WriteLine();

            // Create a new general auction
            Console.WriteLine("Starting a reserve auction");
            Console.WriteLine("-----------------");
            ReserveAuction reserveAuction = new ReserveAuction(new Item("Coffee mug", "Henry Edwards", 3.50M));
            numBids = 0;
            do
            {
                Console.WriteLine("Who is bidding?");
                string bidderRA = Console.ReadLine();
                Console.WriteLine("How much are you bidding?");
                decimal bidAmountRA = decimal.Parse(Console.ReadLine());
                Bid nextBidRA = new Bid(bidderRA, bidAmountRA);
                reserveAuction.PlaceBid(nextBidRA);
                numBids++;
            } while (numBids < 5);

            for (int i = 0; i < reserveAuction.AllBids.Length; i++)
            {
                Console.WriteLine($"{reserveAuction.AllBids[i].Bidder} bid {reserveAuction.AllBids[i].Offer}");
            }


            Console.ReadLine();


        }
    }
}
