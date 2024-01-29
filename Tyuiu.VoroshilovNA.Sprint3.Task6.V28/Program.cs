using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VoroshilovNA.Sprint3.Task6.V28.Lib;

namespace Tyuiu.VoroshilovNA.Sprint3.Task6.V28
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
			Console.WriteLine("* Задание #6                                                                 *");
			Console.WriteLine("* Вариант #28                                                                *");
			Console.WriteLine("* Выполнил: Ворошилов Никита Андреевич | ИСТНб-23-1                          *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому*");
			Console.WriteLine("*отрезку [13, 19] количество всех делителей меньше 7                         *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int startValue = 13;
			int stopValue = 19;

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Результат: " + ds.GetSumTheDivisors(startValue, stopValue));
			Console.ReadKey();
		}
    }
}
