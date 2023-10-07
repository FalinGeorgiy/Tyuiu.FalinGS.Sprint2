using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint2.Task5.V7.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthName()
        {
            DataService ds = new DataService();



            Assert.AreEqual("Январь,1990", ds.FindMonthName(1990,1));
            Assert.AreEqual("Февраль,1990", ds.FindMonthName(1990,2));
            Assert.AreEqual("Март,1990", ds.FindMonthName(1990,3));
            Assert.AreEqual("Апрель,1990", ds.FindMonthName(1990,4));
            Assert.AreEqual("Май,1990", ds.FindMonthName(1990,5));
            Assert.AreEqual("Июнь,1990", ds.FindMonthName(1990,6));
            Assert.AreEqual("Июль,1990", ds.FindMonthName(1990,7));
            Assert.AreEqual("Август,1990", ds.FindMonthName(1990,8));
            Assert.AreEqual("Сентябрь,1990", ds.FindMonthName(1990,9));
            Assert.AreEqual("Октябрь,1990", ds.FindMonthName(1990,10));
            Assert.AreEqual("Ноябрь,1990", ds.FindMonthName(1990,11));
            Assert.AreEqual("Декабрь,1990", ds.FindMonthName(1990,12));

            /*Assert.ThrowsException<ArgumentException>(() =>
            { 
                ds.FindMonthName(1990,-1) ;
            });

            Assert.ThrowsException<ArgumentException>(() =>
            { 
                ds.FindMonthName(1990,0);
                Console.WriteLine("Некорректное значение месяца");
            });*/


        }
    }
}
