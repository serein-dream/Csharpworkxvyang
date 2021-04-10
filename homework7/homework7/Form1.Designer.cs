
using System;
using System.Drawing;

namespace homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.per1bar = new System.Windows.Forms.TrackBar();
            this.txtlength = new System.Windows.Forms.TextBox();
            this.txtdepth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.per2bar = new System.Windows.Forms.TrackBar();
            this.th1bar = new System.Windows.Forms.TrackBar();
            this.th2bar = new System.Windows.Forms.TrackBar();
            this.cayley = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2bar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.cayley);
            this.panel1.Controls.Add(this.th2bar);
            this.panel1.Controls.Add(this.th1bar);
            this.panel1.Controls.Add(this.per2bar);
            this.panel1.Controls.Add(this.per1bar);
            this.panel1.Controls.Add(this.txtlength);
            this.panel1.Controls.Add(this.txtdepth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(439, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 458);
            this.panel1.TabIndex = 0;
            // 
            // per1bar
            // 
            this.per1bar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.per1bar.Location = new System.Drawing.Point(121, 166);
            this.per1bar.Maximum = 9;
            this.per1bar.Minimum = 1;
            this.per1bar.Name = "per1bar";
            this.per1bar.Size = new System.Drawing.Size(109, 56);
            this.per1bar.TabIndex = 11;
            this.per1bar.Value = 6;
            this.per1bar.Scroll += new System.EventHandler(this.per1bar_Scroll);
            // 
            // txtlength
            // 
            this.txtlength.Location = new System.Drawing.Point(134, 115);
            this.txtlength.Name = "txtlength";
            this.txtlength.Size = new System.Drawing.Size(89, 27);
            this.txtlength.TabIndex = 10;
            // 
            // txtdepth
            // 
            this.txtdepth.Location = new System.Drawing.Point(134, 69);
            this.txtdepth.Name = "txtdepth";
            this.txtdepth.Size = new System.Drawing.Size(89, 27);
            this.txtdepth.TabIndex = 9;
            this.txtdepth.TextChanged += new System.EventHandler(this.txtdepth_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "左分支角度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "左分支长度比";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "主干长度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "递归深度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择颜色";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "蓝色",
            "红色",
            "绿色",
            "黑色",
            "黄色"});
            this.comboBox1.Location = new System.Drawing.Point(134, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(89, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(29, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 458);
            this.panel2.TabIndex = 1;
            // 
            // per2bar
            // 
            this.per2bar.Location = new System.Drawing.Point(121, 217);
            this.per2bar.Maximum = 9;
            this.per2bar.Minimum = 1;
            this.per2bar.Name = "per2bar";
            this.per2bar.Size = new System.Drawing.Size(117, 56);
            this.per2bar.TabIndex = 12;
            this.per2bar.Value = 7;
            // 
            // th1bar
            // 
            this.th1bar.Location = new System.Drawing.Point(126, 280);
            this.th1bar.Maximum = 180;
            this.th1bar.Name = "th1bar";
            this.th1bar.Size = new System.Drawing.Size(104, 56);
            this.th1bar.TabIndex = 13;
            this.th1bar.Value = 20;
            // 
            // th2bar
            // 
            this.th2bar.Location = new System.Drawing.Point(126, 342);
            this.th2bar.Maximum = 180;
            this.th2bar.Name = "th2bar";
            this.th2bar.Size = new System.Drawing.Size(104, 56);
            this.th2bar.TabIndex = 14;
            this.th2bar.Value = 30;
            // 
            // cayley
            // 
            this.cayley.AutoSize = true;
            this.cayley.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Bold);
            this.cayley.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cayley.Location = new System.Drawing.Point(3, 2);
            this.cayley.Name = "cayley";
            this.cayley.Size = new System.Drawing.Size(138, 19);
            this.cayley.TabIndex = 15;
            this.cayley.Text = "Cayley树参数设置：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.per1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.per2bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th1bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.th2bar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
            pencolor,
            (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;       
        private System.Windows.Forms.TextBox txtlength;
        private System.Windows.Forms.TextBox txtdepth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar per1bar;
        private System.Windows.Forms.TrackBar per2bar;
        private System.Windows.Forms.TrackBar th1bar;
        private System.Windows.Forms.TrackBar th2bar;
        private System.Windows.Forms.Label cayley;
    }
}

