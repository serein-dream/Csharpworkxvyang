
namespace homework11
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_customer = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Money = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Totalnumber = new System.Windows.Forms.TextBox();
            this.textBox_Totalmoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "顾客名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "订单号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "商品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "商品价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "商品数量";
            // 
            // textBox_customer
            // 
            this.textBox_customer.Location = new System.Drawing.Point(300, 26);
            this.textBox_customer.Name = "textBox_customer";
            this.textBox_customer.Size = new System.Drawing.Size(100, 25);
            this.textBox_customer.TabIndex = 6;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(300, 90);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(100, 25);
            this.textBox_Id.TabIndex = 7;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(300, 148);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 25);
            this.textBox_Name.TabIndex = 8;
            // 
            // textBox_Money
            // 
            this.textBox_Money.Location = new System.Drawing.Point(300, 206);
            this.textBox_Money.Name = "textBox_Money";
            this.textBox_Money.Size = new System.Drawing.Size(100, 25);
            this.textBox_Money.TabIndex = 9;
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(300, 257);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(100, 25);
            this.textBox_Number.TabIndex = 10;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(160, 425);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(188, 51);
            this.submit.TabIndex = 17;
            this.submit.Text = "确认";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "商品总数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "商品总价格";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_Totalnumber
            // 
            this.textBox_Totalnumber.Location = new System.Drawing.Point(300, 307);
            this.textBox_Totalnumber.Name = "textBox_Totalnumber";
            this.textBox_Totalnumber.Size = new System.Drawing.Size(100, 25);
            this.textBox_Totalnumber.TabIndex = 11;
            // 
            // textBox_Totalmoney
            // 
            this.textBox_Totalmoney.Location = new System.Drawing.Point(300, 355);
            this.textBox_Totalmoney.Name = "textBox_Totalmoney";
            this.textBox_Totalmoney.Size = new System.Drawing.Size(100, 25);
            this.textBox_Totalmoney.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 530);
            this.Controls.Add(this.textBox_Totalmoney);
            this.Controls.Add(this.textBox_Totalnumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.textBox_Money);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_customer;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Money;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Totalnumber;
        private System.Windows.Forms.TextBox textBox_Totalmoney;
    }
}