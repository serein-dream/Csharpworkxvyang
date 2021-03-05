using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figureAllPrime
{
    class Program
    {
        static bool IsPrime(int p)
        {
            bool ye = true;
            for(int i=2;i<p; i++)
            {
                if (p % i == 0) ye = false;
            }
            return ye;
        }
        static void Figure(int num)
        {
  //          int [] itsPrime;
 //           itsPrime = new int[100];
            int count = 0;
            int su = 2;
            bool full = false;
            if (num < 2) Console.WriteLine($"{num}无素数因子");
            else
            {
                Console.WriteLine($"{num}的所有素数因子如下： ");
                while (num > 1 && full == false)
                {
                    while (num % su == 0)
                    {
                        Console.WriteLine(su);
                        count++;
                        num = num / su;
                        if (count > 100)
                        {
                            full = true;
                            Console.WriteLine("其素数因子超过100个，过大，在此终止！");
                        }
                    }
                    su++;
                    while (!IsPrime(su) && full == false)
                    {
                        su++;
                    }
                }
            }
           
        }
        static int Check(string a)
        {
            try
            {
                int ans = int.Parse(a);
                return ans;
            }
            catch(Exception e)
            {
                Console.WriteLine("您的输入有问题，请重新输入数字：");
                string aagain = Console.ReadLine();
                return Check(aagain);
            }
        }
        static void Main(string[] args)
        {
            int conti = 1;
            while (conti == 1)
            {
                Console.WriteLine("请输入一个数，我将为您求其所有素数因子（最多不能超过100个）：");
                int numb = Check(Console.ReadLine());
                Figure(numb);
                Console.WriteLine("如果继续请输入 1 ，如果结束请输入 0 ：");
                conti = int.Parse(Console.ReadLine());
            }
        }
    }
}
