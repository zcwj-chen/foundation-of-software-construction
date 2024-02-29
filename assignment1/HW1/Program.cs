namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            double a, b, c;        //a b为输入的两个数字，c为计算结果
            char op;

            Console.WriteLine("请输入一个数：");
            s = Console.ReadLine();
            a = double.Parse(s);
            
            Console.WriteLine("请输入另一个数：");
            s = Console.ReadLine();
            b = double.Parse(s);

            Console.WriteLine("请输入运算符：");
            s = Console.ReadLine();
            op = char.Parse(s);

            switch (op)
            {
                case '+':c = a + b; break;
                case '-':c = a - b; break;
                case '*':c = a * b; break;
                case '/':
                    if(b == 0)
                    {
                        Console.WriteLine("除数不能为0！");
                        return;
                    }
                    else
                        c = a / b;
                    break;
                case '%':c = a % b; break;
                default:
                    Console.WriteLine("无效运算符！");
                    return;
            }
            //c = Math.Round(c);
            decimal d = (decimal)c;       //处理小数计算的误差
            Console.WriteLine($"计算结果：{a} {op} {b} = {d}");
        }
    }
}