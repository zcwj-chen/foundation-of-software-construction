using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle() { }
        public Rectangle(double w,double h) 
        {
            width = w;
            height = h;
        }

        public double Width { set; get; }
        public double Height { set; get; }

        public double calArea()
        {
            return width * height;
        }

        public bool isLegal()
        {           
            return (width > 0 && height > 0);
        }
    }
}
