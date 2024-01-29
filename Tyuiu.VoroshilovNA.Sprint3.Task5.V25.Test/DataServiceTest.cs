using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint3.Task5.V25.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int startValue1 = 1;
            int stopValue1 = 3;

            int startValue2 = 1;
            int stopValue2 = 10;

            int x = 2;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 7.621;

            Assert.AreEqual(wait, res);
        }
    }
}
