using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NUMS_LENGTH = 5;
            int[] nums = new int[NUMS_LENGTH] {1,2,3,4,5 };

            GenericList<int> list = new GenericList<int>();
            for(int i = 0; i < NUMS_LENGTH; i++)
            {
                list.add(nums[i]);
            }

            list.ForEach(PrintNode);

            int max = list.Head.Data;
            list.ForEach(m => max = max > m ? max : m);
            Console.WriteLine($"max = {max}");

            int min = list.Head.Data;
            list.ForEach(m => min = min < m ? min : m);
            Console.WriteLine($"min = {min}");

            int sum = 0;
            list.ForEach(m => sum += m);
            Console.WriteLine($"sum = {sum}");
        }

        static void PrintNode(int n)
        {
            Console.WriteLine(n);
        }
    }
}