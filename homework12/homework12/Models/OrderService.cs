using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework12.Models
{
    [Serializable]
    public class OrderService
    {
        [Key]
        public string OrderServiceId { get; set; }
     //   public static List<Order> Myorder;

        public OrderService(string id)
        {
            OrderServiceId = id;
     //       Myorder = new List<Order>();
        }

        public OrderService()
        {
            OrderServiceId = Guid.NewGuid().ToString();
       //     Myorder = new List<Order>();
        }
        public override string ToString()
        {
            return OrderServiceId;
        }
    }
}
