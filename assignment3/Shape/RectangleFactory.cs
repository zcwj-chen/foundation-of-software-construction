using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class RectangleFactory : ShapeFactory
    {
        public Shape createShape()
        {
            Random r1 = new Random();
            Random r2 = new Random();

            double w = r1.Next(50) + r1.NextDouble();
            double h = r2.Next(50) + r2.NextDouble();

            return new Rectangle(w, h);
        }
    }
}
