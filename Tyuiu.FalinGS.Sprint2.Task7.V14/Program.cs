using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task7.V14.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Title = "Спринт #2 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №7                                                              #");
            Console.WriteLine("* Вариант №14                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите значение переменной х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите значение переменной у: ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result                                                                  #");
            Console.WriteLine("###########################################################################");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области ");
            }
            else
            {
                Console.WriteLine("Точка  НЕ находится в заштрихованной области ");
            }

            Console.ReadKey();
        }
    }
}
