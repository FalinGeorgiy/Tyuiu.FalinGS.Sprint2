using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task1.V30.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a,b,c,d);

            Console.Title = "Спринт #1 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №1                                                          #");
            Console.WriteLine("* Вариант №30                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result:                                                                 #");
            Console.WriteLine("###########################################################################");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }


            Console.ReadKey();
        }
    }
}
