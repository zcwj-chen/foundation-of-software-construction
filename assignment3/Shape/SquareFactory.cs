using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class SquareFactory : ShapeFactory
    {
        public Shape createShape()
        {
            Random r = new Random();
            double s = r.NextDouble() + r.Next(50);

            return new Square(s);
        }
    }
}
