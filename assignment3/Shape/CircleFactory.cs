using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class CircleFactory : ShapeFactory
    {
        public Shape createShape()
        {
            Random r = new Random();
            double rad = r.NextDouble() + r.Next(50);

            return new Circle(rad);
        }
    }
}
