using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using homework6;

namespace homework8
{
    public partial class Form2 : Form
    {
        public Order order = new Order();
        public OrderDetails good = new OrderDetails();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Order order_,OrderDetails good_)
        {
            InitializeComponent();
            textBox_customer.DataBindings.Add("Text", order_, "Customer");
            textBox_Id.DataBindings.Add("Text", order_, "Id");
            textBox_Money.DataBindings.Add("Text", good_, "Spmoney");
            textBox_Name.DataBindings.Add("Text", good_, "Spname");
            textBox_Number.DataBindings.Add("Text", good_, "Spnumber");
            textBox_Totalnumber.DataBindings.Add("Text", order_, "Number");
            textBox_Totalmoney.DataBindings.Add("Text", order_, "Totalmoney");
        }
        public void submit_Click(object sender,EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Order theorder = new Order(order.Customer, order.Id, new List<OrderDetails> { good });/*
            order.Number += good.Spnumber;
            order.Totalmoney += good.Spnumber * good.Spmoney;
            order.Spinformation += good.ToString();*/
            /*
            bool sameorder = false;
            foreach(var torder in OrderService.Myorder)
            {
                if (torder.Id == theorder.Id) sameorder = true;
            }
            if (sameorder)  //订单已存在，加商品
            {
                Order similarOrder = OrderService.QueryById(order.Id);
                similarOrder.Sp.Add(good);
            }
            else                                          //订单不存在，加订单
            {
                OrderService.AddOrder(theorder);
            }
            */
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
