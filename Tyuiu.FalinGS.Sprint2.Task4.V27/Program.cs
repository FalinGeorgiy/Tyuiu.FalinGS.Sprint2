using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task4.V27.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №4                                                              #");
            Console.WriteLine("* Вариант №27                                                              #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите переменную Х:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите переменную Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x,y);




            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result:                                                                 #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Значение функции:" + res);



            Console.ReadKey();
        }
    }
}
