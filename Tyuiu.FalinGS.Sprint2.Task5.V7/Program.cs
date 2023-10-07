using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task5.V7.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #2 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №5                                                              #");
            Console.WriteLine("* Вариант №7                                                              #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите number Mouth:");
            int n = Convert.ToInt32(Console.ReadLine());
            int startYear = 1990;

            string res;

            if (n <= -1)
            {
                res = ("Недопустимый формат");
            }



            else
            {
                res = ("Год и Mecяц = " + ds.FindMonthName(startYear, n));
            }
            



            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Result:                                                                 #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Значение функции:" + res);



            Console.ReadKey();
        }
    }
}
