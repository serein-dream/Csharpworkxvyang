using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//2019302110112 马旭阳


namespace work1
{
    class Program
    {
        static void Calculate1(double m, double n, char s)
        {
            double ans;
            switch (s)
            {
                case '+':
                    ans = m + n;
                    Console.WriteLine($"{m} + {n} = {ans}");
                    break;
                case '-':
                    ans = m - n;
                    Console.WriteLine($"{m} - {n} = {ans}");
                    break;
                case '*':
                    ans = m * n;
                    Console.WriteLine($"{m} * {n} = {ans}");
                    break;
                case '/':
                    if (n == 0)
                    {
                        Console.WriteLine("除法运算第二个数不能为0，请重新输入第二个数：");
                        double p = double.Parse(Console.ReadLine());
                        Calculate1(m, p, s);
                    }
                    else
                    {
                        ans = m / n;
                        Console.WriteLine($"{m} / {n} = {ans}");
                    }
                    break;
                case '%':
                    if (n == 0)
                    {
                        Console.WriteLine("不能对0取余，请重新输入第二个数：");
                        double z = double.Parse(Console.ReadLine());
                        Calculate1(m, z, s);
                    }
                    else
                    {
                        ans = m % n;
                        Console.WriteLine($"{m} % {n} = {ans}");
                    }
                    break;
                    //2019302110112 马旭阳
                default:
                    Console.WriteLine("所选运算操作不在功能范围内，请按下面提示重新输入：");
                    Console.WriteLine("支持+、-、*、/、%，请选择所要进行的运算操作：");
                    char ss = char.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第一个运算数： ");
                    double mm = double.Parse(Console.ReadLine());
                    Console.WriteLine("请输入第二个运算数： ");
                    double nn = double.Parse(Console.ReadLine());
                    Calculate1(mm, nn, ss);
                    break;
            }
        }
        static void Main(string[] args)
        {
            int t = 1;
            while (t == 1)
            {
                Console.WriteLine("支持+、-、*、/、%，请选择所要进行的运算操作：");
                char operate = char.Parse(Console.ReadLine());
                Console.WriteLine("请输入第一个运算数： ");
                double number1 = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入第二个运算数： ");
                double number2 = double.Parse(Console.ReadLine());
                Calculate1(number1, number2, operate);
                Console.WriteLine("如果退出，输入0；继续运算，输入1： ");
                t = int.Parse(Console.ReadLine());
            }
        }
    }
}
