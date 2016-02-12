// *************************************************
// Deck.Logic.Suit.cs
// Last Modified: 02/12/2016 12:26 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    public enum PipType
    {
        Heart,
        Diamond,
        Spade,
        Club
    }

    public enum ColorType
    {
        Red,
        Black
    }

    public struct Suit
    {
        public PipType Pip { get; set; }
        public ColorType Color { get; set; }
    }

    public static class Suits
    {
        public static Suit[] GetSuits()
        {
            return new Suit[]
            {
                new Suit {Pip = PipType.Heart, Color = ColorType.Red},
                new Suit {Pip = PipType.Diamond, Color = ColorType.Red},
                new Suit {Pip = PipType.Spade, Color = ColorType.Black},
                new Suit {Pip = PipType.Club, Color = ColorType.Black}
            };
        }
    }
}