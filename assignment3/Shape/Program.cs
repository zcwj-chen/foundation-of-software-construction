using System.Reflection.Metadata.Ecma335;

namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("创建形状个数：");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"随机{n}个形状面积和：{calSumArea(n)}");
        }

        public static double calSumArea(int n)
        {
            //随机创建十个形状对象，计算总面积
            double sumArea = 0;            

            for (int i = 0; i < n; i++)
            {
                Shape shape = null;

                switch (i % 4)
                {
                    case 0:
                        RectangleFactory rf = new RectangleFactory();
                        shape = rf.createShape();
                        break;
                    case 1:
                        SquareFactory sf = new SquareFactory();
                        shape = sf.createShape();
                        break;
                    case 2:
                        TriangleFactory tf = new TriangleFactory();
                        shape = tf.createShape();
                        break;
                    case 3:
                        CircleFactory cf = new CircleFactory();
                        shape = cf.createShape();
                        break;
                    default:
                        break;
                }
                if (shape.isLegal())
                    sumArea += shape.calArea();

            }

            return sumArea;
        }
    }
}