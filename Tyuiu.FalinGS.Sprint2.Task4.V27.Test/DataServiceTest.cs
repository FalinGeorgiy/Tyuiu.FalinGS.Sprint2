using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint2.Task4.V27.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondotion1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 24.8;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondotion2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 24.8;
            Assert.AreEqual(wait, res);

        }
    }
}
