// *************************************************
// Deck.Tests.CardTests.cs
// Last Modified: 02/12/2016 12:28 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Tests.Logic
{
    using System;
    using System.Linq;
    using Deck.Logic;
    using NUnit.Framework;

    [TestFixture()]
    public class CardTests
    {
        [Test]
        public void Deck_Has52Cards()
        {
            var cards = Deck.GetCards();
            Assert.AreEqual(52, cards.Length);
            var count = cards.Count(x => x != null && x.Suit.Pip == PipType.Club);
            Assert.AreEqual(13, count);
            count = cards.Count(x => x != null && x.Suit.Pip == PipType.Diamond);
            Assert.AreEqual(13, count);
            count = cards.Count(x => x != null && x.Suit.Pip == PipType.Heart);
            Assert.AreEqual(13, count);
            count = cards.Count(x => x != null && x.Suit.Pip == PipType.Spade);
            Assert.AreEqual(13, count);
        }

        [Test]
        [Repeat(50)]
        public void Deck_Shuffles()
        {
            var cards = Deck.GetCards();
            var orderedCards = (Card[]) cards.Clone();
            //Console.WriteLine("Running shuffle test");

            cards = Deck.Shuffle(cards);
            var diffCount = 0;
            var threshold = 40;
            for (var i = 0; i < orderedCards.Length; i++)
            {
                // At least one card must be different
                // Rare chance this could fail erroneously if the Random gods fail us
                if (orderedCards[i].CompareTo(cards[i]) != 0)
                {
                    diffCount++;
                }
            }
            Assert.GreaterOrEqual(diffCount, threshold, String.Format("At least {0} cards must be different. Shuffle is not good enough", threshold));
        }
    }
}