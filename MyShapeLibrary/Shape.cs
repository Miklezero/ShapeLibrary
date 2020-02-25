using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapeLibrary
{
    public class Shape
    {
        public int R;
        public int NumberSide;
        //площадь круга по радиусу
        public double Square(double a)
        {
            return Math.PI * a * a;
        }
        //площадь треугольника по трем сторонам
        public double Square(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
