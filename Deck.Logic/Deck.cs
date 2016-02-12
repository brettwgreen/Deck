// *************************************************
// Deck.Logic.Deck.cs
// Last Modified: 02/12/2016 12:27 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    using System;

    public static class Deck
    {
        public static Card[] GetCards()
        {
            return Card.GetCards();
        }

        public static Card[] Shuffle()
        {
            return Shuffle(Card.GetCards());
        }

        public static Card[] Shuffle(Card[] cards)
        {
            var r = new Random(21452512);
            var l = cards.Length;
            for (var i = 0; i < l; i++)
            {
                var swap = r.Next(0, l - 1);
                var c1 = cards[i];
                cards[i] = cards[swap];
                cards[swap] = c1;
                //Console.WriteLine(string.Format("Swapped '{0}' with '{1}'", Cards[swap], Cards[i]));
            }
            return cards;
        }
    }
}