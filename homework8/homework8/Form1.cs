using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using homework6;

namespace homework8
{
    public partial class Form1 : Form
    {
        public OrderService Os = new OrderService();
        public string check { get; set; }
        public string fileName = @"./orders.xml";
        public Form1()
        {
            InitializeComponent();
            OrderService.AddOrder(new Order("马旭阳", 0112, new List<OrderDetails> { new OrderDetails("查拉图斯特拉如是说", 44, 1), new OrderDetails("飞鸟集", 20, 2) }));
            OrderService.AddOrder(new Order("张三", 3112, new List<OrderDetails> { new OrderDetails("哈利波特", 84, 1), new OrderDetails("不知所云", 30, 4) }));
            OrderService.AddOrder(new Order("李四", 0520, new List<OrderDetails> { new OrderDetails("波西杰克逊", 74, 5), new OrderDetails("累死了啊啊啊啊", 10, 11) }));
            orderBindingSource.DataSource = OrderService.Myorder;
/*            Order currentorder = OrderService.QueryById((int)dataGridView1.CurrentRow.Cells[1].Value);
            if (currentorder != null)
            {
                orderDetailsBindingSource.DataSource = currentorder.Sp;
            }
 */
            textBox_view.DataBindings.Add("Text", this, "check");
        }
        //删
        private void Button_deleteOrder_Click(object sender,EventArgs e)
        {
            int OrderId = (int)dataGridView1.CurrentRow.Cells[1].Value;
            // OrderService.Deleteorder(OrderId);
            Order order = OrderService.QueryById(OrderId);
            if (order != null)
            {
                OrderService.Deleteorder(OrderId);
            }
            orderBindingSource.ResetBindings(false);
        }
        //查
        private void Button_viewbyId_Click(object sender,EventArgs e)
        {
            if(check == null || check == "")
            {
                orderBindingSource.DataSource = OrderService.Myorder;
            }
            else
            {
                int OrderId;
                bool result = Int32.TryParse(check, out OrderId);
                orderBindingSource.DataSource = OrderService.QueryById(OrderId);
            }
        }
        
        private void Button_viewbyCustomer_Click(object sender,EventArgs e)
        {
            if (check == null || check == "")
            {
                orderBindingSource.DataSource = OrderService.Myorder;
            }
            else
            {
                orderBindingSource.DataSource = OrderService.QueryByCustomer(check);
            }
        }

        private void Button_viewbyName_Click(object sender, EventArgs e)
        {
            if (check == null || check == "")
            {
                orderBindingSource.DataSource = OrderService.Myorder;
            }
            else
            {
                orderBindingSource.DataSource = OrderService.QueryByName(check);
            }
        }

        //导入
        private void Buttom_import_click(object sender,EventArgs e)
        {
            OrderService.Import(fileName);
        }

        //导出
        private void Button_export_click(object sender,EventArgs e)
        {
            OrderService.Export(OrderService.Myorder,fileName);
            orderBindingSource.ResetBindings(false);
        }

        //增
        private void Button_creat_click(object sender,EventArgs e)
        {
            Order order = new Order();
            OrderDetails good = new OrderDetails();
            order.AddItem(good);
            OrderService.AddOrder(order);
            Form2 form2 = new Form2(order, good);
            form2.Show(this);
            orderBindingSource.ResetBindings(false);
        }

        //改
        private void Button_modify_click(object sender,EventArgs e)
        {
            int theId = (int)dataGridView1.CurrentRow.Cells[1].Value;
            Order theorder = OrderService.QueryById(theId);
            string Spname = (string)dataGridView2.CurrentRow.Cells[0].Value;
            OrderDetails good = theorder.querybySpname(Spname);
            Form2 form2 = new Form2(theorder, good);
            form2.Show();
        }
        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
