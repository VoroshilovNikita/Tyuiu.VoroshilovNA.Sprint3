using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VoroshilovNA.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= startValue2; j++)
                {
                    sumSeries += (Math.Pow(x, j) + Math.Cos(j));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
