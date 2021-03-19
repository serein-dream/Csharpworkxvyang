using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_1
{
    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

    //下面是添加的代码！！！！ ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）
    public void Foreach(Action<T> action)
        {
            Node<T> f =head;
            while (f != null)
            {
                action(f.Data);
                f = f.Next;
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            //添加的代码！
            int minl = intlist.Head.Data;
            int maxl = intlist.Head.Data;
            int suml = 0;
            intlist.Foreach (Console.WriteLine);//输出链表元素
            intlist.Foreach(thisdata =>
            {
                if (minl > thisdata) minl = thisdata;
            }
                );//求最小值
            intlist.Foreach(thisdata =>
            {
                if (maxl < thisdata) maxl = thisdata;
            }
                );//求和
            intlist.Foreach(thisdata =>suml+=thisdata );
            Console.WriteLine($"链表的最大值是：{maxl}");
            Console.WriteLine($"链表的最小值是：{minl}");
            Console.WriteLine($"链表的和是：    {suml}");
            Console.WriteLine("输入任意字符结束：");//避免闪退
            string s = Console.ReadLine();

        }

    }
}
