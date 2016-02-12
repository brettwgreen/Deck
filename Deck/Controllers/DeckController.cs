// *************************************************
// Deck.DeckController.cs
// Last Modified: 02/12/2016 4:13 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Controllers
{
    using System.Web.Http;
    using System.Web.Http.Cors;
    using Logic;

    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class DeckController : ApiController
    {
        [HttpGet]
        [Route("deck/cards")]
        public Card[] GetCards()
        {
            return Deck.GetCards();
        }

        [HttpPost]
        [Route("deck/shuffle")]
        public Card[] Shuffle(Card[] cards)
        {
            return Deck.Shuffle(cards);
        }

        [HttpGet]
        [Route("deck/shuffle")]
        public Card[] Shuffle()
        {
            return Deck.Shuffle(Deck.GetCards());
        }
    }
}