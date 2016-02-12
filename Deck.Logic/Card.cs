// *************************************************
// Deck.Logic.Card.cs
// Last Modified: 02/12/2016 12:32 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    using System;

    public class Card : IComparable
    {
        public Suit Suit { get; set; }
        public string Rank { get; set; }

        internal static string[] RankOrder = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"};

        internal static Card[] GetCards()
        {
            var cards = new Card[52];
            var i = 0;
            var suits = Suits.GetSuits();
            foreach (var suit in suits)
            {
                foreach (var rank in RankOrder)
                {
                    cards[i] = new Card() {Rank = rank, Suit = suit};
                    i++;
                }
            }
            return cards;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}s", Rank, Suit.Pip);
        }

        public int CompareTo(object obj)
        {
            var card = (Card) obj;
            if (card.Suit.Equals(this.Suit) && card.Rank == this.Rank)
                return 0;
            var o1 = Array.IndexOf<string>(RankOrder, this.Rank);
            var o2 = Array.IndexOf<string>(RankOrder, card.Rank);
            if (o1 < o2)
            {
                return -1;
            }
            return 1;
        }
    }
}