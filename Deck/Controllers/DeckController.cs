// *************************************************
// Deck.DeckController.cs
// Last Modified: 02/12/2016 11:49 AM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Controllers
{
    using System.Web.Http;
    using Logic;

    public class DeckController : ApiController
    {
        public IDeck Deck { get; set; }
    }
}