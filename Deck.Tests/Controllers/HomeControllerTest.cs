// *************************************************
// Deck.Tests.HomeControllerTest.cs
// Last Modified: 02/12/2016 8:54 AM
// Modified By: Green, Brett (greenb1)
// *************************************************

namespace Deck.Tests.Controllers
{
    using System.Web.Mvc;
    using Deck.Controllers;
    using NUnit.Framework;

    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}