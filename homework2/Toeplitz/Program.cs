using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2019302110112 马旭阳
//4.托普利茨矩阵

namespace Toeplitz
{
    class Program
    {
        static bool isequal(int [,] arry,int i,int j,int m,int n)
        {
            int t = arry[i,j];
            while (i < m && j < n)
            {
                if (arry[i,j] != t) return false;
                i++;
                j++;
            }
            return true;

        }
        static void Main(string[] args)
        {
            int again = 1;
            while (again == 1)
            {
                Console.WriteLine("请依次输入该托普利茨矩阵的行数M和列数N：");
                int M = int.Parse(Console.ReadLine());
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入该托普利茨矩阵：");
                int[,] arry = new int[M, N];
                for (int p = 0; p < M; p++)
                {
                    char[] s = new char[] { ' ' };
                    string[] arr = Console.ReadLine().Split(s);
                    int[] arry1 = new int[N];
                    arry1 = Array.ConvertAll<string, int>(arr, m => int.Parse(m));
                    for (int q = 0; q < N; q++)
                    {
                        arry[p, q] = arry1[q];
                    }                   
                }
                int istop = 1;
                for (int i = 0; i < M; i++)
                {
                    if (!isequal(arry, i, 1, M, N)) istop = 0;
                }
                for (int j = 0; j < N; j++)
                {
                    if (!isequal(arry, 1, j, M, N)) istop = 0;
                }
                if (istop == 1) Console.WriteLine("True");
                if (istop == 0) Console.WriteLine("False");
                Console.WriteLine("输入0结束，输入1再来一次： ");
                again = int.Parse(Console.ReadLine());
            }
        }
    }
}
