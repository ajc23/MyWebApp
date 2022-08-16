using System;
using System.Web.Mvc;
using MyWebApp.Controllers;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class HomeControllerTest
    {
        [TestCase()]
        public void TestContactView()
        {
            var controller = new HomeController();
            var result = controller.Contact() as ViewResult;
            Assert.AreEqual("Contact", result.ViewName);
        }
    }
}
