using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

//输出用户指定数据的所有素数因子。
namespace assignment2.ConsoleApp1
{
    internal class task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个数：");
            string s = Console.ReadLine();
            int num = int.Parse(s);

            /*int facLen;    //素数因子的个数
            int[] result = getPrimeFactors(num,out facLen);

            //输出
            for(int i = 0; i < facLen; i++)
            {
                Console.WriteLine(result[i] + ' ');
            }*/

            getPrimeFactor(num);
        }

        //连锁法

        static void getPrimeFactor(int n)
        {
            int i = 2;
            int m = n;
            bool iHasWrite = false;
            while (m != 1)
            {
                if (m % i == 0)
                {
                    m = m / i;
                    if(!iHasWrite) Console.WriteLine(i);
                    iHasWrite = true;
                }
                else
                {
                    i++;
                    iHasWrite = false;
                }
            }

        }

        /*static int[] getPrimeFactors(int n, out int facNum)
        {
            int[] priFac = new int[n];
            facNum = 0;

            for (int i = 2; i < n; i++)
            {
                //整除，是因子且该因子是素数
                if (n % i == 0 && isPrimeNum(i))
                {
                    priFac[facNum] = i;
                    facNum++;
                }
            }
            return priFac;
        }

        //判断一个数是不是素数
        static bool isPrimeNum(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }*/
    }
}
