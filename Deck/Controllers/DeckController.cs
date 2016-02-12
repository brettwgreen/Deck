// *************************************************
// Deck.DeckController.cs
// Last Modified: 02/12/2016 12:29 PM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Controllers
{
    using System.Web.Http;
    using Logic;

    public class DeckController : ApiController
    {
        [HttpGet]
        [Route("deck/cards")]
        public Card[] GetCards()
        {
            return Deck.GetCards();
        }
    }
}