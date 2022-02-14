using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_12
{
    static class Krug
    {
        static public double GetLenght(double R)
        {
            return 2 * Math.PI * R;        
        }
        static public double GetSquare(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        static public string GetPoint(double R, double x0, double y0, double x, double y)
        {
            double x1 = x0 + R;
            double y1 = y0 + R;
            if (x1 > x || y1 > y)
            {
                return "Точка принадлежит окружности";
            }
            else
            {
                return "Точка не принадлежит окружности";
            }
           

        }
    }
}
