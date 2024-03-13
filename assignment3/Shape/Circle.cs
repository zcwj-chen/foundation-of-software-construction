using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        private double radius;
        public double Radius { get; set; }

        public Circle() { }
        public Circle(double r)
        {
            radius = r;
        }

        public double calArea()
        {
            return radius * radius*Math.PI;
        }

        public bool isLegal()
        {
            return radius > 0;
        }

    }
}
