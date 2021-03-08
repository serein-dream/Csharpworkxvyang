using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
//2019302110112 马旭阳
//3.用“埃氏筛法”求2~ 100以内的素数。

/*numissu是一个有100个元素的数组，每个元素的初始值是1，比如numissu[i]=0代表i不是素数,次次筛选，发现i是j的倍数则
置numissu[i]=0*/
namespace Figure1to100Prime
{
    class Program
    {
        static void deletenum(int d,ref int [] numissu)
        {
            for (int i=0; i <100; i++)
            {
                if (i % d == 0 && i/d>1 && numissu[i]==1 ||i==1) // “&& numissu[i]==1”减少了进入if内部的次数
                {
                    numissu[i] = 0;
                }
                
            }
        }
        static void figure(int []numissu)
        {
            int l = 100;
            for (int j = 2; j < 11; j++)
            {
                deletenum( j,ref numissu);
            }
            Console.WriteLine("1~100中的素数有： ");      
            for (int i = 0; i < 100; i++)
            {
                if(numissu[i]==1) Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int[] numissu = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numissu[i] = 1;
            }
            figure(numissu );
            Console.WriteLine("输入0结束程序： ");//避免闪退
            string endth = Console.ReadLine();

        }
    }
}

