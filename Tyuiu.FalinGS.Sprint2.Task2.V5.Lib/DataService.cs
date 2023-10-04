using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FalinGS.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            //



            if (((x>=3 && y>=3)&&(x<6 && y<6)))
            { 
                res = true;
            }
            else if (x == 9 && y > 2 && y < 4)
            {
                res = true;
            }
            else if (x > 10 && x < 13 && y > 2 && y < 5)
            {
                res = true;
            }
            else if (x == 5 && y >= 6 && y <= 7)
            {
                res = true;
            }
            else if (x >= 6 && x <= 8 && y >= 5 && y <= 11)
            {
                res = true;
            }
            else if (x >= 9 && x <= 12 && y >= 5 && y <= 6)
            {
                res = true;
            }
            else if (x == 13 && y >= 6 && y <= 8)
            {
                res = true;
            }
            else if (x >= 3 && x <= 5 && y == 11)
            {
                res = true;
            }
            else if (x >= 7 && x <= 10 && y == 12)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;


        }
    }
}
