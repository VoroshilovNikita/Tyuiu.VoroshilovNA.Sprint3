using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = { "Красный", "Оранжевый", "Жёлтый", "Зелёный", "Голубой"};
            foreach (string item in data)
            {
                if (item.Length == 6)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }
    }
}
