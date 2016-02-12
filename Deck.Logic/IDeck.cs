// *************************************************
// Deck.Logic.IDeck.cs
// Last Modified: 02/12/2016 11:11 AM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Logic
{
    public interface IDeck
    {
        Card[] Cards { get; set; }

        void Shuffle();
    }
}