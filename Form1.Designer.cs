using homework6;
namespace homework11
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
            this.components = new System.ComponentModel.Container();
            this.button_creatOrder = new System.Windows.Forms.Button();
            this.button_modifyOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_view = new System.Windows.Forms.TextBox();
            this.button_viewbyName = new System.Windows.Forms.Button();
            this.button_viewbyCustomer = new System.Windows.Forms.Button();
            this.button_viewbyId = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_importOrder = new System.Windows.Forms.Button();
            this.button_exportOrder = new System.Windows.Forms.Button();
            this.button_deleteOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.spnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_creatOrder
            // 
            this.button_creatOrder.AutoSize = true;
            this.button_creatOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_creatOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_creatOrder.Location = new System.Drawing.Point(77, 0);
            this.button_creatOrder.Name = "button_creatOrder";
            this.button_creatOrder.Size = new System.Drawing.Size(77, 52);
            this.button_creatOrder.TabIndex = 0;
            this.button_creatOrder.Text = "创建订单";
            this.button_creatOrder.UseVisualStyleBackColor = true;
            this.button_creatOrder.Click += new System.EventHandler(this.Button_creat_click);
            // 
            // button_modifyOrder
            // 
            this.button_modifyOrder.AutoSize = true;
            this.button_modifyOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_modifyOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_modifyOrder.Location = new System.Drawing.Point(0, 0);
            this.button_modifyOrder.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button_modifyOrder.Name = "button_modifyOrder";
            this.button_modifyOrder.Size = new System.Drawing.Size(77, 52);
            this.button_modifyOrder.TabIndex = 1;
            this.button_modifyOrder.Text = "修改订单";
            this.button_modifyOrder.UseVisualStyleBackColor = true;
            this.button_modifyOrder.Click += new System.EventHandler(this.Button_modify_click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBox_view);
            this.panel1.Controls.Add(this.button_viewbyName);
            this.panel1.Controls.Add(this.button_viewbyCustomer);
            this.panel1.Controls.Add(this.button_viewbyId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_importOrder);
            this.panel1.Controls.Add(this.button_exportOrder);
            this.panel1.Controls.Add(this.button_deleteOrder);
            this.panel1.Controls.Add(this.button_creatOrder);
            this.panel1.Controls.Add(this.button_modifyOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(939, 72);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox_view
            // 
            this.textBox_view.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_view.Location = new System.Drawing.Point(706, 0);
            this.textBox_view.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBox_view.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_view.MinimumSize = new System.Drawing.Size(200, 25);
            this.textBox_view.Name = "textBox_view";
            this.textBox_view.Size = new System.Drawing.Size(200, 25);
            this.textBox_view.TabIndex = 14;
            // 
            // button_viewbyName
            // 
            this.button_viewbyName.AutoSize = true;
            this.button_viewbyName.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_viewbyName.Location = new System.Drawing.Point(599, 0);
            this.button_viewbyName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_viewbyName.Name = "button_viewbyName";
            this.button_viewbyName.Size = new System.Drawing.Size(107, 52);
            this.button_viewbyName.TabIndex = 13;
            this.button_viewbyName.Text = "按商品名查询";
            this.button_viewbyName.UseVisualStyleBackColor = true;
            this.button_viewbyName.Click += new System.EventHandler(this.Button_viewbyName_Click);
            // 
            // button_viewbyCustomer
            // 
            this.button_viewbyCustomer.AutoSize = true;
            this.button_viewbyCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_viewbyCustomer.Location = new System.Drawing.Point(492, 0);
            this.button_viewbyCustomer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_viewbyCustomer.Name = "button_viewbyCustomer";
            this.button_viewbyCustomer.Size = new System.Drawing.Size(107, 52);
            this.button_viewbyCustomer.TabIndex = 12;
            this.button_viewbyCustomer.Text = "按顾客名查询";
            this.button_viewbyCustomer.UseVisualStyleBackColor = true;
            this.button_viewbyCustomer.Click += new System.EventHandler(this.Button_viewbyCustomer_Click);
            // 
            // button_viewbyId
            // 
            this.button_viewbyId.AutoSize = true;
            this.button_viewbyId.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_viewbyId.Location = new System.Drawing.Point(385, 0);
            this.button_viewbyId.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.button_viewbyId.Name = "button_viewbyId";
            this.button_viewbyId.Size = new System.Drawing.Size(107, 52);
            this.button_viewbyId.TabIndex = 11;
            this.button_viewbyId.Text = "按订单号查询";
            this.button_viewbyId.UseVisualStyleBackColor = true;
            this.button_viewbyId.Click += new System.EventHandler(this.Button_viewbyId_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 10;
            // 
            // button_importOrder
            // 
            this.button_importOrder.AutoSize = true;
            this.button_importOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_importOrder.Location = new System.Drawing.Point(308, 0);
            this.button_importOrder.Name = "button_importOrder";
            this.button_importOrder.Size = new System.Drawing.Size(77, 52);
            this.button_importOrder.TabIndex = 4;
            this.button_importOrder.Text = "导入订单";
            this.button_importOrder.UseVisualStyleBackColor = true;
            this.button_importOrder.Click += new System.EventHandler(this.Buttom_import_click);
            // 
            // button_exportOrder
            // 
            this.button_exportOrder.AutoSize = true;
            this.button_exportOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_exportOrder.Location = new System.Drawing.Point(231, 0);
            this.button_exportOrder.Name = "button_exportOrder";
            this.button_exportOrder.Size = new System.Drawing.Size(77, 52);
            this.button_exportOrder.TabIndex = 3;
            this.button_exportOrder.Text = "导出订单";
            this.button_exportOrder.UseVisualStyleBackColor = true;
            this.button_exportOrder.Click += new System.EventHandler(this.Button_export_click);
            // 
            // button_deleteOrder
            // 
            this.button_deleteOrder.AutoSize = true;
            this.button_deleteOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_deleteOrder.Location = new System.Drawing.Point(154, 0);
            this.button_deleteOrder.Name = "button_deleteOrder";
            this.button_deleteOrder.Size = new System.Drawing.Size(77, 52);
            this.button_deleteOrder.TabIndex = 2;
            this.button_deleteOrder.Text = "删除订单";
            this.button_deleteOrder.UseVisualStyleBackColor = true;
            this.button_deleteOrder.Click += new System.EventHandler(this.Button_deleteOrder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel2.Size = new System.Drawing.Size(939, 274);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.spnameDataGridViewTextBoxColumn,
            this.spmoneyDataGridViewTextBoxColumn,
            this.spnumberDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderDetailsBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(939, 269);
            this.dataGridView2.TabIndex = 1;
            // 
            // spnameDataGridViewTextBoxColumn
            // 
            this.spnameDataGridViewTextBoxColumn.DataPropertyName = "Spname";
            this.spnameDataGridViewTextBoxColumn.HeaderText = "Spname";
            this.spnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spnameDataGridViewTextBoxColumn.Name = "spnameDataGridViewTextBoxColumn";
            this.spnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // spmoneyDataGridViewTextBoxColumn
            // 
            this.spmoneyDataGridViewTextBoxColumn.DataPropertyName = "Spmoney";
            this.spmoneyDataGridViewTextBoxColumn.HeaderText = "Spmoney";
            this.spmoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spmoneyDataGridViewTextBoxColumn.Name = "spmoneyDataGridViewTextBoxColumn";
            this.spmoneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // spnumberDataGridViewTextBoxColumn
            // 
            this.spnumberDataGridViewTextBoxColumn.DataPropertyName = "Spnumber";
            this.spnumberDataGridViewTextBoxColumn.HeaderText = "Spnumber";
            this.spnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spnumberDataGridViewTextBoxColumn.Name = "spnumberDataGridViewTextBoxColumn";
            this.spnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "Sp";
            this.orderDetailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework6.Order);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 289);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.totalmoneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(939, 289);
            this.dataGridView1.TabIndex = 1;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 84;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 52;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalmoneyDataGridViewTextBoxColumn
            // 
            this.totalmoneyDataGridViewTextBoxColumn.DataPropertyName = "Totalmoney";
            this.totalmoneyDataGridViewTextBoxColumn.HeaderText = "Totalmoney";
            this.totalmoneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalmoneyDataGridViewTextBoxColumn.Name = "totalmoneyDataGridViewTextBoxColumn";
            this.totalmoneyDataGridViewTextBoxColumn.Width = 116;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_creatOrder;
        private System.Windows.Forms.Button button_modifyOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_importOrder;
        private System.Windows.Forms.Button button_exportOrder;
        private System.Windows.Forms.Button button_deleteOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderServiceBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn spnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spmoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_view;
        private System.Windows.Forms.Button button_viewbyName;
        private System.Windows.Forms.Button button_viewbyCustomer;
        private System.Windows.Forms.Button button_viewbyId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmoneyDataGridViewTextBoxColumn;
    }
}

