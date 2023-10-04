using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint2.Task3.V27.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.223;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.223;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.223;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.223;
            Assert.AreEqual(wait, res);
        }

    }
}
