using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//马旭阳
//2019302110112
namespace work1
{
        interface Shape
        {
            double Area { get; }
            bool Islegal();
        }
        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Length { get; set; }
            public Rectangle(double lenth_,double width_)
            {
                this.Width = width_;
                this.Length = lenth_;
                if (Islegal())
                {
                    Console.WriteLine($"Rectangle:  its length is  {this.Length}  ,its width is {this.Width} ,and its area is   {this.Area}");
                }
                else
                {
                   Console.WriteLine("illegal");
                }
            }
            public double Area
            {
                get => Width * Length;
            }
            public bool Islegal()
            {
                return (Width > 0 && Length > 0);
            }
            public string Show()
            {
                if (Islegal()) {
                    return "Rectangle:  " + "its length is " + Length + " ,its width is " + Width + " ,and its area is  " + Area;
                        }
                else
                {
                    return "illegal";
                }
            }
        }

        class Square : Shape
        {
            public double Side { get; set; }
            public Square(double side_)
            {
                this.Side = side_;
                 if (Islegal())
                {
                    Console.WriteLine($"Square:  its Side is  {this.Side}  ,and its area is   {this.Area}");
                }
                else
                {
                   Console.WriteLine("illegal");
                }               
            }
            public double Area
            {
                get => Side * Side;
            }
            public bool Islegal()
            {
                return (Side > 0);
            }
            public string Show()
            {
                if (Islegal())
                {
                    return "this Square :  " + "its side is  " + Side + " ,and its area is  " + Area;
                }
                else
                {
                    return "";
                }
            }
        }

        class Triangle : Shape
        {
            public double Side1 { get; set; }
            public double Side2 { get; set; }
            public double Side3 { get; set; }
            public Triangle(double side1_,double side2_,double side3_)
            {
                this.Side1 = side1_;
                this.Side2 = side2_;
                this.Side3 = side3_;
                if (Islegal())
                {
                    Console.WriteLine($"Triangle:  its sides are  {this.Side1}   ,{this.Side2}   ,{this.Side3}   ,and its area is   {this.Area}");
                }
                else
                {
                   Console.WriteLine("illegal");
                }
            }
            public double Area
            {
                get => Math.Sqrt((Side1+Side2+Side3)*(Side3+Side2-Side1)*(Side1+Side3-Side2)*(Side1+Side2-Side3))/16;
            }
            public bool Islegal()
            {
                return (Side1>0&&Side2>0&&Side3>0)&&(Side1+Side2>Side3)&&(Side1+Side3>Side2)&&(Side2+Side3>Side1);
            }
            public string Show()
            {
                if (Islegal())
                {
                    return "this Triangle: " + "its sides are:  " + Side1 + "  and  " + Side2 + "  and  " + Side3 + " , and its area is  " + Area;
                }
                else
                {
                    return "";
                }
            }
        }
        class ShapeFactory
        {
            public static Shape Produce(int kind,params double [] numbers)
            {
                switch(kind){
                    case 0:
                        if (numbers.GetLength(0) < 2)
                        {
                            throw new ArgumentException("长方形的参数应该为2个");
                        }
                        return new Rectangle(numbers[0], numbers[1]);
                    case 1:
                        if (numbers.GetLength(0) < 1)
                        {
                        throw new ArgumentException("正方形的参数应该为1个");
                        }
                        return new Square(numbers[0]);
                    case 2:
                        if (numbers.GetLength(0) < 3)
                        {
                            throw new ArgumentException("三角形的参数应该为3个");
                        }
                        return new Triangle(numbers[0], numbers[1], numbers[2]);
                    default:
                        return null;
                }
            }
        }
    class Program
    {
        static void Main(string[] arges)
        {
            string n = "1";
            while (n == "1")
            {
    //            Random ran = new Random(Guid().NewGuid().GetHashCode());
                double areasummary = 0;
                int i = 0;
                while(i<10)
                {
                    byte[] bytes = new byte[4];
                    System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                    rng.GetBytes(bytes);
                    int t = BitConverter.ToInt32(bytes, 0);
                    Random ran = new Random(t);//网上查到的解决伪随机的方案，经测试可行
                    int kind = ran.Next() % 3;
                    Shape thisshape = ShapeFactory.Produce(kind, ran.Next(0, 10), ran.Next(0, 10), ran.Next(0, 10));
                    if (thisshape.Islegal())
                    {
                        areasummary += thisshape.Area;
                        i += 1;
                    }
                }
                Console.WriteLine($"这10个图形的面积之和为{areasummary}");
                Console.WriteLine("输入0结束,输入1再来一次：");
                n = Console.ReadLine();
            }
        }
    }
}
