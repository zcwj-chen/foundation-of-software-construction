using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal interface ShapeFactory
    {
        Shape createShape();
    }
    /*internal class ShapeFactory
    {
        public static Shape createShape(String s)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();

            double num1 = r1.Next(100) + r1.NextDouble();
            double num2 = r2.Next(100) + r2.NextDouble();
            double num3 = r3.Next(100) + r3.NextDouble();

            switch (s)
            {
                case "Rectangle":
                    return new Rectangle(num1, num2);
                    break;
                case "Square":
                    return new Square(num1);
                    break;
                case "Triangle":
                    return new Triangle(num1, num2, num3);
                    break;
                case "Circle":
                    return new Circle(num1);
                    break;
                default:
                    return null;
                    break;
            }
        }
    }*/
}
