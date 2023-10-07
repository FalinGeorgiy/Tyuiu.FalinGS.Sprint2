using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FalinGS.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {

        public string FindMonthName(int startYear, int n)
        {
            string res;

            if (n > 12)
            {
                n = (n + 1) % 12;
                startYear = 1990 + n;
                (n, startYear).ToString();
            }




            switch (n)
            {
                case 1:
                    res = $"Январь,{startYear}";
                    break;
                case 2:
                    res = $"Февраль,{startYear}";
                    break;
                case 3:
                    res = $"Март,{startYear}";
                    break;
                case 4:
                    res = $"Апрель,{startYear}";
                    break;
                case 5:
                    res = $"Май,{startYear}";
                    break;
                case 6:
                    res = $"Июнь,{startYear}";
                    break;
                case 7:
                    res = $"Июль,{startYear}";
                    break;
                case 8:
                    res = $"Август,{startYear}";
                    break;
                case 9:
                    res = $"Сентябрь,{startYear}";
                    break;
                case 10:
                    res = $"Октябрь,{startYear}";
                    break;
                case 11:
                    res = $"Ноябрь,{startYear}";
                    break;
                case 12:
                    res = $"Декабрь,{startYear}";
                    break;
                default:
                    res = "Недопустимый месяц";
                    break;
            }

            return (res);



        }
    }
}
