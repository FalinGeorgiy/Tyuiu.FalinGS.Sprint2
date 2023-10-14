using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.FalinGS.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;

            if (((y >= -1) && (y <= 1) && (x <= 1) && (x >= 0)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y >= x && y >= -x && x >= 0 && y >= 0))
            //((y >= x && y >= -x && x >= 0 && y >= 0) || (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1))
            //( ((y>=-1)&&(y<=1)&&(x<=1)&&(x>=0)) && (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (y>=-x && y>=x))
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
