using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint2.Task6.V4.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();


            Assert.AreEqual("Шестерка", ds.FindCardSuit(6));
            Assert.AreEqual("Семерка", ds.FindCardSuit(7));
            Assert.AreEqual("Восьмерка", ds.FindCardSuit(8));
            Assert.AreEqual("Девятка", ds.FindCardSuit(9));
            Assert.AreEqual("Десятка", ds.FindCardSuit(10));
            Assert.AreEqual("Валет", ds.FindCardSuit(11));
            Assert.AreEqual("Дама", ds.FindCardSuit(12));
            Assert.AreEqual("Король", ds.FindCardSuit(13));
            Assert.AreEqual("Туз", ds.FindCardSuit(14));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(5);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(15);
            });
        }
    }
}
