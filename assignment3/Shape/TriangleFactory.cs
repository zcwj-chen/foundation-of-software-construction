using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class TriangleFactory : ShapeFactory
    {
        public Shape createShape()
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();

            double a = r1.NextDouble() + r1.Next(50);
            double b = r2.NextDouble() + r2.Next(50);
            double c = r3.NextDouble() + r3.Next(50);

            return new Triangle(a, b, c);
        }
        
    }
}
