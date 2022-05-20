using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using AlgorithmDecide.Controllers;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmDecide.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [Fact]
        public void TestingViewForIndex()
        {
            HomeController HomeControllerObject = new HomeController();
            ViewResult viewResultForHomeController = HomeControllerObject.Index() as ViewResult;
            string s = viewResultForHomeController.ViewName.ToString();
            Console.WriteLine(s);
           // Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(null,s);
        } 
    }
}
