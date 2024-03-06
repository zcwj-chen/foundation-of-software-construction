using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。
namespace assignment2
{
    internal class task4
    {
        static void Main(string[] args)
        {
            int[,] matrix1 =
            {
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 1, 2}
            };
            int[,] matrix2 =
{
                {1, 2, 3, 4},
                {5, 1, 2, 3},
                {9, 5, 0, 2},
                {1, 2, 3, 1},
                {5, 1, 2, 3},
                {9, 5, 0, 2}
            };

            Console.WriteLine("matrix1: " + isToeplitz(matrix1, matrix1.GetLength(0) ,matrix1.GetLength(1)));
            Console.WriteLine("matrix2: " + isToeplitz(matrix2, matrix2.GetLength(0), matrix2.GetLength(1)));
        }

        static bool isToeplitz(int[,] matrix,int m,int n)
        {
            for(int i = 1; i < n && i < m; i++)
            {
                if (matrix[i,i] != matrix[0,0]) return false;
            }
            return true;
        }
    }
}
