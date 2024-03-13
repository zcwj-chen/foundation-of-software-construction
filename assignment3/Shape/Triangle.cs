using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle : Shape
    {
        private double a, b, c;
        public double A { set; get; }
        public double B { set; get; }
        public double C { set; get; }

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double calArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        }
        public bool isLegal()
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            else if ((a + b) > c && (b + c) > a && (c + a) > b)
            {
                return true;
            }
            else
                return false;
        }
    }
}
