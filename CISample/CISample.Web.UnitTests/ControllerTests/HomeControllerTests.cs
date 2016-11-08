using System.Web.Mvc;
using CISample.Web.Controllers;
using NUnit.Framework;

namespace CISample.Web.UnitTests.ControllerTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController();
        }

        [Test]
        public void IndexActionReturnsView()
        {
            // Act
            var viewResult = _controller.Index() as ViewResult;

            // Assert
            Assert.IsInstanceOf<ViewResult>(viewResult);
        }

        [Test]
        public void AboutActionReturnsView()
        {
            // Act
            var viewResult = _controller.About() as ViewResult;

            // Assert
            Assert.IsInstanceOf<ViewResult>(viewResult);
            Assert.AreEqual("Your application description page.", viewResult.ViewBag.Message);
        }
    }
}