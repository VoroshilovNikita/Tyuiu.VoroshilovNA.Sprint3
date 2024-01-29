using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoroshilovNA.Sprint3.Task7.V28.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Ворошилов Н. А. | ИСТНб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #3                                                                  *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                               *");
            Console.WriteLine("* Задание #7                                                                 *");
            Console.WriteLine("* Вариант #28                                                                *");
            Console.WriteLine("* Выполнил: Ворошилов Никита Андреевич | ИСТНб-23-1                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на заданном   *");
            Console.WriteLine("*диапазоне. Произвести проверку деления на ноль.                             *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                            *");
            Console.WriteLine("******************************************************************************");
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");
            for(int i = 0; i<=len-1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");



            Console.ReadKey();
        }
    }
}
