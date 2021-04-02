using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
//马旭阳
//2019302110112
namespace homework6
{
    public class OrderDetails : Object
    {
        public string Spname { get; set; }
        public int Spmoney { get; set; }
        public int Spnumber { get; set; }
        public OrderDetails(string spname, int spmoney, int spnumber)
        {
            this.Spmoney = spmoney;
            this.Spname = spname;
            this.Spnumber = spnumber;
        }
        public OrderDetails()
        {

        }
        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.Spmoney == Spmoney && m.Spname == Spname && m.Spnumber == Spnumber;
        }
        public override string ToString()
        {
            return "commodity:  " + Spname + "  ,itsmoney is :  " + Convert.ToString(Spmoney) + "  ,itsnumber is :  " + Convert.ToString(Spnumber) + "\n";
        }
        public override int GetHashCode()
        {
            int result = Spname.GetHashCode();
            result = 17 * result + Spmoney.GetHashCode();
            result = 17 * result + Spnumber.GetHashCode();
            return result;
        }
    }
    public class Order : Object
    {
        public OrderDetails[] Sp { get; set; }
        public int Number { get; set; }

        public int Id { get; set; }
        public string Customer { get; set; }
        public int Totalmoney { get; set; }
        public string Spinformation { get; set; }
        public Order()
        {

        }
        public Order(string customer, int id, params OrderDetails[] p)
        {
            this.Customer = customer;
            this.Id = id;
            for (int i = 0; i < p.Length; i++)
            {
                this.Number += p[i].Spnumber;
                this.Totalmoney += p[i].Spnumber * p[i].Spmoney;
                this.Spinformation += p[i].ToString();
            }
            Sp = p;
        }
        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && m.Number == Number && m.Customer == Customer && m.Totalmoney == Totalmoney;
        }
        public override string ToString()
        {
            string s = "this order's id is:  " + Convert.ToString(Id) + " ,and its customer is :  " + Customer + " ,Totalnumber is :  " + Convert.ToString(Number) + " , and its Totalmoney is :  " + Convert.ToString(Totalmoney) + "\n";
            s += Spinformation;
            return s;
        }
        public override int GetHashCode()
        {
            int result = Id.GetHashCode();
            result = 17 * result + Number.GetHashCode();
            result = 17 * result + Totalmoney.GetHashCode();
            return result;
        }
    }

    public class OrderService
    {
        public static List<Order> Myorder = new List<Order>();

        public OrderService()
        {

        }

        //增
        public static bool AddOrder(Order order)
        {
            if (order == null || order.Sp == null)
                throw new ArgumentException("订单不能为空且订单内的商品不能为空");
            if (Myorder.Where(m => m.Id == order.Id).Any())
            {
                return false;
            }
            Myorder.Add(order);
            return true;
        }

        //删
        public static void Deleteorder(int orderId)
        {
            var query = Myorder.Where(m => m.Id == orderId).FirstOrDefault();
            if (query == null)
            {
                throw new InvalidOperationException("要删除的订单不存在！");
            }
            Myorder.Remove(query);
        }

        //查
        public static IEnumerable<Order> QueryById(int checkId)
        {
            var query = from m in Myorder
                        where m.Id == checkId
                        select m;
            return query;
        }
        public static IEnumerable<Order> QueryByName(string checkName)
        {
            var query = from m in Myorder
                        where m.Sp.Where(n => n.Spname == checkName).Any()
                        select m;
            return query;
        }
        public static IEnumerable<Order> QueryByCustomer(string checkcustomer)
        {
            var query = from m in Myorder
                        where m.Customer == checkcustomer
                        select m;
            return query;
        }

        public static IEnumerable<Order> QueryAll()
        {
            return from m in Myorder
                   orderby m.Id
                   select m;
        }

        public static IEnumerable<Order> QueryByAmount(int x, int y)
        {
            int minnum, maxnum;
            if (x < y)
            {
                minnum = x;
                maxnum = y;
            }
            else
            {
                minnum = y;
                maxnum = x;
            }
            var query = from m in Myorder
                        where m.Number >= minnum && m.Number <= maxnum
                        select m;
            return query;
        }

        //改
        public static void EditOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentException("参数不能为空！");
            }
            var thisorder = Myorder.Where(m => m.Id == order.Id).FirstOrDefault();
            if (thisorder == null)
            {
                throw new InvalidOperationException("要编辑的订单不存在！");
            }
            if (order.Sp != null && order.Sp.Length > 0)
            {
                thisorder.Sp = order.Sp;
            }
            if (!string.IsNullOrEmpty(order.Customer))
            {
                thisorder.Customer = order.Customer;
            }
            if (order.Totalmoney > 0)
            {
                thisorder.Totalmoney = order.Totalmoney;
            }
            if (order.Number > 0)
            {
                thisorder.Number = order.Number;
            }
        }
        
        //以下为新增代码
        //序列化为XML文件
        public static string Export(List<Order> Seorders,string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Seorders);
            }
            return filename;
        }

        //将xml文件里的订单载入
        public static void Import(string beloadname)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream beload = new FileStream(beloadname, FileMode.Open))
            {
                List<Order> toload = (List<Order>)xmlSerializer.Deserialize(beload);
                List<Order> sum = toload.Union(Myorder).ToList<Order>();
                Myorder = sum;
            }
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            //public Order(string customer,int id, params OrderDetails[] p)   public OrderDetails(string spname, int spmoney, int spnumber)
            OrderService.AddOrder(new Order("马旭阳", 0112, new OrderDetails("查拉图斯特拉如是说", 44, 1), new OrderDetails("飞鸟集", 20, 2)));
            OrderService.AddOrder(new Order("张三", 3112, new OrderDetails("哈利波特", 84, 1), new OrderDetails("不知所云", 30, 4)));
            OrderService.AddOrder(new Order("李四", 0520, new OrderDetails("波西杰克逊", 74, 5), new OrderDetails("累死了啊啊啊啊", 10, 11)));
            Console.WriteLine("查询所有订单，按订单的商品数量排序： ");
            var que_1 = OrderService.QueryAll();
            foreach (var theorder in que_1)
            {
                Console.WriteLine(theorder.ToString());
            }


            //以下为新增代码
            Console.WriteLine("将以上订单转为xml文件：");
            Console.WriteLine(File.ReadAllText(OrderService.Export(OrderService.Myorder,"s.xml")));

            Order Tobeload = new Order("王五", 6112, new OrderDetails("挑战程序设计竞赛", 54, 1), new OrderDetails("计算机组成与设计", 130, 2));
            List<Order> Neworder = new List<Order>();
            Neworder.Add(Tobeload);
            Console.WriteLine("新产生订单:");
            Console.WriteLine(File.ReadAllText(OrderService.Export(Neworder, "n.xml")));
            OrderService.Import(OrderService.Export(Neworder, "n.xml"));

            Console.WriteLine("加入新产生的订单后，所有订单如下： ");
            var que_2 = OrderService.QueryAll();
            foreach (var theorder in que_2)
            {
                Console.WriteLine(theorder.ToString());
            }

            /*
            Console.WriteLine("按顾客查询： ");
            var que_2 = OrderService.QueryByCustomer("马旭阳");
            foreach (var theorder in que_2)
            {
                Console.WriteLine(theorder.ToString());
            }


            Console.WriteLine("按订单号查询： ");
            var que_3 = OrderService.QueryByCustomer("0520");
            foreach (var theorder in que_3)
            {
                Console.WriteLine(theorder.ToString());
            }


            Console.WriteLine("按商品名查询： ");

            var que_4 = OrderService.QueryByCustomer("哈利波特");
            foreach (var theorder in que_4)
            {
                Console.WriteLine(theorder.ToString());
            }



            Console.WriteLine("修改订单： ");
            OrderService.EditOrder(new Order("画意", 3112));
            var que_5 = OrderService.QueryById(3112);
            foreach (var theorder in que_5)
            {
                Console.WriteLine(theorder.ToString());
            }


            Console.WriteLine("删除订单： ");
            OrderService.Deleteorder(0520);
            var que_6 = OrderService.QueryById(0520);
            foreach (var theorder in que_6)
            {
                Console.WriteLine(theorder.ToString());
            }

           */
            Console.WriteLine("输入任意符号结束： ");
            string g = Console.ReadLine();
        }
    }
}

