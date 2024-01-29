using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint3.Task0.V30.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 2477.158;

            Assert.AreEqual(wait, res);
        }
    }
}
