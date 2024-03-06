using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
namespace assignment2
{
    internal class task2
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 ,4,5,6,7,8,9,10};
            int max1, min1, avg1, sum1;

            calculate(arr1,out max1,out min1,out avg1,out sum1);
            Console.WriteLine("arr1 max: " + max1);
            Console.WriteLine("arr1 min: " + min1);
            Console.WriteLine("arr1 avg: " + avg1);
            Console.WriteLine("arr1 sum: " + sum1);
        }

        static void calculate(int[] nums,out int max,out int min,out int avg,out int sum)
        {
            sum = 0;
            max = nums[0];
            min = nums[0];
            foreach(int i in nums)
            {
                max = i > max ? i : max;
                min = i < min ? i : min;
                sum += i;
            }
            avg = sum / nums.Length;
        }
    }
}
