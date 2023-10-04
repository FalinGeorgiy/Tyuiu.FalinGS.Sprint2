using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task0.V18.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 5105;
            int y = 475;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #1 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №0                                                          #");
            Console.WriteLine("* Вариант №18                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result:                                                                 #");
            Console.WriteLine("###########################################################################");

            for (int i=0; i<6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();

        }
    }
}
