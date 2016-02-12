// *************************************************
// Deck.Logic.Suit.cs
// Last Modified: 02/12/2016 12:34 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

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
        [JsonConverter(typeof (StringEnumConverter))]
        public PipType Pip { get; set; }

        [JsonConverter(typeof (StringEnumConverter))]
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