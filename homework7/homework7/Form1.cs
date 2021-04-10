using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pencolor = Pens.Blue;
        int length = 80;
        int depth = 10;
        public void button1_Click(object sender, EventArgs e)
        {
            if (graphics != null) graphics.Clear(panel2.BackColor);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pencolor = Pens.Blue;
                    break;
                case 1:
                    pencolor = Pens.Red;
                    break;
                case 2:
                    pencolor = Pens.Green;
                    break;
                case 3:
                    pencolor = Pens.Black;
                    break;
                case 4:
                    pencolor = Pens.Yellow;
                    break;
                default:
                    pencolor = Pens.Blue;
                    break;
            }
            try
            {
               per2 = Convert.ToDouble(per2bar.Value)/10;
               per1 = Convert.ToDouble(per1bar.Value)/10;
               th2 = Convert.ToDouble(th2bar.Value)*Math.PI / 180;
               th1 = Convert.ToDouble(th1bar.Value)*Math.PI / 180;
               depth = Convert.ToInt32(txtdepth.Text);
               length = Convert.ToInt32(txtlength.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入数据错误！");
            }
            if (graphics == null) graphics = panel2.CreateGraphics();
            drawCayleyTree(depth, 200, 310, length, -Math.PI / 2);//递归深度，根点x,根点y，长度，初始角度
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtdepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            

        }
        
        private void per1bar_Scroll(object sender, EventArgs e)
        {

        }/*
        private void per2bar_Scroll(object sender, EventArgs e)
        {

        }*/
    }
}
