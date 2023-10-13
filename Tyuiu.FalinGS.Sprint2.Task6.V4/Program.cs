using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FalinGS.Sprint2.Task6.V4.Lib;

namespace Tyuiu.FalinGS.Sprint2.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №2                                                               #");
            Console.WriteLine("* Задание №6                                                              #");
            Console.WriteLine("* Вариант №4                                                              #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Введите номер карты: ");
            int numCard = Convert.ToInt32(Console.ReadLine());

            string res;

            if (numCard<6 && numCard > 14)
            {
                res = "Введено неверное значение";
            } 
            else
            {
                res = "Эта карта:" + ds.FindCardSuit(numCard);
            }


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Результат:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(res);

            Console.ReadKey();


        }
    }
}
