using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//2019302110112 马旭阳
//16--div  1--one
namespace WindowsFormscalculate2
{
    public partial class Form1 : Form
    {
        double number1 = 0;
        double number2 = 0;
        double ans;
        int havesign = 0;  //如果还没输符号则为0，如果输了符号则为1
        char sign;
        string number1_s = "";
        string number2_s = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += '0';
            if (havesign == 0) number1_s += '0';
            if (havesign == 1) number2_s += '0';
        }
        /*       private void button1_Click(object sender, EventArgs e)
               {
                   textBox1.Text += '1';
                   if (havesign == 0) number1_s += '1';
                   if (havesign == 1) number2_s += '1';
               }
           */
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += '1';
            if (havesign == 0) number1_s += '1';
            if (havesign == 1) number2_s += '1';
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += '2';
            if (havesign == 0) number1_s += '2';
            if (havesign == 1) number2_s += '2';
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += '3';
            if (havesign == 0) number1_s += '3';
            if (havesign == 1) number2_s += '3';
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += '4';
            if (havesign == 0) number1_s += '4';
            if (havesign == 1) number2_s += '4';
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += '5';
            if (havesign == 0) number1_s += '5';
            if (havesign == 1) number2_s += '5';
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += '6';
            if (havesign == 0) number1_s += '6';
            if (havesign == 1) number2_s += '6';
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += '7';
            if (havesign == 0) number1_s += '7';
            if (havesign == 1) number2_s += '7';
        }

        private void eight_Click(object sender, EventArgs e)
        {
            //2019302110112 马旭阳
            textBox1.Text += '8';
            if (havesign == 0) number1_s += '8';
            if (havesign == 1) number2_s += '8';
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += '9';
            if (havesign == 0) number1_s += '9';
            if (havesign == 1) number2_s += '9';
        }

        private void add_Click(object sender, EventArgs e)
        {
            textBox1.Text += '+';
            sign = '+';
            havesign = 1;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            textBox1.Text += '-';
            sign = '-';
            havesign = 1;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            textBox1.Text += '*';
            sign = '*';
            havesign = 1;
        }

        private void button16_Click(object sender, EventArgs e)//div
        {
            textBox1.Text += '/';
            sign = '/';
            havesign = 1;
        }
        private void fig_Click(object sender, EventArgs e)
        {
            textBox1.Text += '=';
            number1 = Convert.ToDouble(number1_s);
            number2 = Convert.ToDouble(number2_s);
            switch (sign)
            {
                case '+':
                    ans = number1 + number2;
                    textBox1.Text += Convert.ToDouble(ans);
                    break;
                case '-':
                    ans = number1 - number2;
                    textBox1.Text += Convert.ToDouble(ans);
                    break;
                case '*':
                    ans = number1 * number2;
                    textBox1.Text += Convert.ToDouble(ans);
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        textBox1.Text += "错误！不能除以0！";
                    }
                    else
                    {
                        ans = number1 / number2;
                        textBox1.Text += Convert.ToDouble(ans);
                        break;
                    }
                    break;
                default:
                    break;
            }
            textBox1.Text += "   运算结束，请按CE键重新开始";
        }

        private void clean_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            number1 = 0;
            number2 = 0;
            number1_s = "";
            number2_s = "";
            havesign = 0;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
