using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12.Models
{
    [Serializable]
    public class Order : IComparable
    {
        [Key]
        public string OrderId { get; set; }
        public string OrderServiceID { get; set; }
        public OrderService OrderService { get; set; }
        public List<OrderDetail> Sp { get; set; }
        public int Number { get; set; }
        public string Customer { get; set; }
        public int Totalmoney { get; set; }
        public string Spinformation { get; set; }
        public Order()
        {
            OrderId = Guid.NewGuid().ToString();
            Sp = new List<OrderDetail>();
            OrderService = new OrderService("001");
        }
        /*
        public Order(string customer, string id, List<OrderDetail> p)
        {
            this.Customer = customer;
            this.OrderId = id;
            this.OrderService = new OrderService("number001");
            for (int i = 0; i < p.Count; i++)
            {
                this.Number += p[i].Spnumber;
                this.Totalmoney += p[i].Spnumber * p[i].Spmoney;
                this.Spinformation += p[i].ToString();
            }
            Sp = p;
        }*/
        public Order(string customer, string id, List<OrderDetail> p,OrderService o)
        {
            this.Customer = customer;
            this.OrderId = id;
            this.OrderService = o;
            for (int i = 0; i < p.Count; i++)
            {
                this.Number += p[i].Spnumber;
                this.Totalmoney += p[i].Spnumber * p[i].Spmoney;
                this.Spinformation += p[i].ToString();
            }
            this.Sp = p;
        }

        public int CompareTo(object obj)
        {
            Order od = obj as Order;
            if (od != null)
            {
                int id1 = Convert.ToInt32(this.OrderId.Remove(0, 1));
                int id2 = Convert.ToInt32(od.OrderId.Remove(0, 1));
                return id1 - id2;
            }
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            Order m = obj as Order;
            return m != null && OrderId != m.OrderId;
        }
        public override string ToString()
        {
            string s = "this order's id is:  " + Convert.ToString(OrderId) + " ,and its customer is :  " + Customer + " ,Totalnumber is :  " + Convert.ToString(Number) + " , and its Totalmoney is :  " + Convert.ToString(Totalmoney) + "\n";
            s += Spinformation;
            return s;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
            /*
            int result = OrderId.GetHashCode();
            result = 17 * result + Number.GetHashCode();
            result = 17 * result + Totalmoney.GetHashCode();
            return result;
            */
        }
        public void RemoveOrderDetail(OrderDetail od)
        {
            Sp.Remove(od);
        }

        public void AddOrderDetail(OrderDetail od)
        {
            /*
            using (var db = new OrderContext())
            {
                db.goods.Add(orderItem);
                db.SaveChanges();
            }*/
            
            if (Sp.Contains(od))
            {
                throw new ApplicationException($"orderDetails-{od} is already existed!");
            }
            Sp.Add(od);
        }
        public OrderDetail querybySpname(string thename)
        {
            return Sp.Where(m => m.Spname == thename).FirstOrDefault();
        }
    }
}
