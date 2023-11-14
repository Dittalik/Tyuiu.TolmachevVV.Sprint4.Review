using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint4.Review.V24.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Review.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(1179648, service1.Calculate(5, 3, "651827384219648"));
        }
    }
}
