// *************************************************
// Deck.Logic.Deck.cs
// Last Modified: 02/12/2016 11:12 AM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    using System;

    public class Deck : IDeck
    {
        public Card[] Cards { get; set; }

        public Deck()
        {
            Cards = Card.GetCards();
        }

        public void Shuffle()
        {
            var r = new Random(21452512);
            var l = Cards.Length;
            for (var i = 0; i < l; i++)
            {
                var swap = r.Next(0, l - 1);
                var c1 = Cards[i];
                Cards[i] = Cards[swap];
                Cards[swap] = c1;
                //Console.WriteLine(string.Format("Swapped '{0}' with '{1}'", Cards[swap], Cards[i]));
            }
        }
    }
}