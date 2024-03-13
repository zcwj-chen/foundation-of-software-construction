using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : Shape
    {
        private double side;
        public double Side { set; get; }

        public Square() { }
        public Square(double s)
        {
            this.side = s;
        }

        public double calArea()
        {
            return side*side;
        }

        public bool isLegal()
        {
            return side > 0;
        }
    }
}
