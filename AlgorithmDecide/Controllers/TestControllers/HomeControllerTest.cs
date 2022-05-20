using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmDecide.Controllers.TestControllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestHomeControllerIndexView()
        {
            var controllerObject = new HomeController();
            var result = controllerObject.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);

        }
    }
}
