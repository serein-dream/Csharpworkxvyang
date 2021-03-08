using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2019302110112 马旭阳
//2.编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

namespace FigureArray
{
    class Program
    {
        static  int Check(string num)
        {
            try
            {
                int ans = int.Parse(num);
                return ans;
            }
            catch(Exception e)
            {
                Console.WriteLine("只能输入整数，请重新输入： ");
                string numagain = Console.ReadLine();
                return Check(numagain);
            }

        }
        static void FigureArray(int [] arr)
        {
            int arrLength = arr.GetLength(0);
            if (arrLength == 0)
            {
                Console.WriteLine("数组为空！");
                return;
            }
            int minnum=arr[0];
            int maxnum=arr[0];
            int sumnum=0;
            for(int i = 0; i < arrLength; i++)
            {
                if (minnum > arr[i]) minnum = arr[i];
                if (maxnum < arr[i]) maxnum = arr[i];
                sumnum += arr[i];
            }
            double eva = Convert.ToDouble(sumnum) / arr.GetLength(0);
            Console.WriteLine($"数组中最大的元素是：  {maxnum}");
            Console.WriteLine($"数组中最小的元素是：  {minnum}");
            Console.WriteLine($"数组中元素的和是：    {sumnum}");
            Console.WriteLine($"数组中元素的平均值是：    {eva}");
        }
        static void Main(string[] args)
        {
            int endth = 1;//避免闪退
            while (endth == 1)
            {
                Console.WriteLine("请输入数组的元素个数 ： ");
                int Arraynumber = Check(Console.ReadLine());
                Console.WriteLine("请输入该数组的元素，每个元素用换行分割 ：");
                int[] IntArray = new int[Arraynumber];
                for (int i = 0; i < Arraynumber; i++)
                {
                    IntArray[i] = Check(Console.ReadLine());
                }
                FigureArray(IntArray);
                Console.WriteLine("输入0结束程序,输入1再来一次： ");
                endth = Check(Console.ReadLine());
            }
        }
    }
}
