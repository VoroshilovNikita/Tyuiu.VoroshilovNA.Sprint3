using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint3.Task6.V28.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisiors()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 17;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 111;

            Assert.AreEqual(res, wait);
        }
    }
}
