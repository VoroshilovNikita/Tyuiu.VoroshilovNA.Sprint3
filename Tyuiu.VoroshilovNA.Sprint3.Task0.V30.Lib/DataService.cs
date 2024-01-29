using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VoroshilovNA.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries = MultiplySeries * (i / Math.Pow(Math.Sin(1), -10));
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
