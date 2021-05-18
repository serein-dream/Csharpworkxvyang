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
    public class OrderDetail
    {
        [Key]
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public string Spname { get; set; }
        public int Spmoney { get; set; }
        public int Spnumber { get; set; }
        public OrderDetail(string spname, int spmoney, int spnumber)
        {
            this.Spmoney = spmoney;
            this.Spname = spname;
            this.Spnumber = spnumber;
            this.OrderDetailId = Guid.NewGuid().ToString();
        }
        public OrderDetail()
        {
            this.OrderDetailId = Guid.NewGuid().ToString();
            this.Spmoney = 0;
            this.Spname = "空商品";
            this.Spnumber = 0;
        }
        public override bool Equals(object obj)
        {
            var m = obj as OrderDetail;
            return m != null && m.OrderDetailId != OrderDetailId;
        }
        public override string ToString()
        {
            return "commodity:  " + Spname + "  ,itsmoney is :  " + Convert.ToString(Spmoney) + "  ,itsnumber is :  " + Convert.ToString(Spnumber) + "\n";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
