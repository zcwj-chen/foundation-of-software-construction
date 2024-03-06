using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。

namespace assignment2
{
    internal class task3
    {
        static void Main(string[] args)
        {
            bool[] isRemoved = sieve(2, 100);

            for (int i = 2; i < isRemoved.Length; i++)
            {
                if (!isRemoved[i])
                    Console.WriteLine(i);
            }
        }

        static bool[] sieve(int min,int max)
        {
            bool[] isDeleted = new bool[max+1];

            int i = 2;
            while(i*i < max)
            {
                if (!isDeleted[i])
                {
                    for(int j = i*i;j <= max;j += i)
                        isDeleted[j] = true;
                }              
                i++;
            }
            return isDeleted;
        }
    }
}
