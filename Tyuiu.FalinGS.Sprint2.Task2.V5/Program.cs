using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task2.V5.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.Title = "Спринт #1 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №2                                                              #");
            Console.WriteLine("* Вариант №5                                                              #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите переменную Х:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите переменную Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result:                                                                 #");
            Console.WriteLine("###########################################################################");


           if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области!:");
            }
           else
            {
                Console.WriteLine("Точка находится НЕ в заштрихованной области!");
            }

            Console.ReadKey();
        }
    }
}
