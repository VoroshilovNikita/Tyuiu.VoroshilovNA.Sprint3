using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoroshilovNA.Sprint3.Task4.V7.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue; int stopValue;


            Console.Title = "Спринт #3 | Выполнил: Ворошилов Н. А. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Ворошилов Никита Андреевич | ИСТНб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя данные, вычисляет *");
            Console.WriteLine("* их и печатает их на экран.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите пременную старта суммирования: ");

            startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите пременную предела суммирования: ");
            stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда равна:\n{ds.Calculate(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
