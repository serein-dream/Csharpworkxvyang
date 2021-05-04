
namespace homework10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textmax = new System.Windows.Forms.TextBox();
            this.crawlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.statelabel = new System.Windows.Forms.Label();
            this.Buttonstart = new System.Windows.Forms.Button();
            this.textStartURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textmax);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.statelabel);
            this.panel1.Controls.Add(this.Buttonstart);
            this.panel1.Controls.Add(this.textStartURL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 117);
            this.panel1.TabIndex = 0;
            // 
            // textmax
            // 
            this.textmax.Location = new System.Drawing.Point(234, 50);
            this.textmax.Name = "textmax";
            this.textmax.Size = new System.Drawing.Size(100, 25);
            this.textmax.TabIndex = 6;
            this.textmax.TextChanged += new System.EventHandler(this.maxnum_TextChanged);
            // 
            // crawlerBindingSource
            // 
           this.crawlerBindingSource.DataSource = typeof(homework10.Crawler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(88, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "最大数量：";
            // 
            // statelabel
            // 
            this.statelabel.AutoSize = true;
            this.statelabel.Location = new System.Drawing.Point(231, 95);
            this.statelabel.Name = "statelabel";
            this.statelabel.Size = new System.Drawing.Size(0, 15);
            this.statelabel.TabIndex = 4;
            // 
            // Buttonstart
            // 
            this.Buttonstart.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Buttonstart.Location = new System.Drawing.Point(653, 16);
            this.Buttonstart.Name = "Buttonstart";
            this.Buttonstart.Size = new System.Drawing.Size(111, 41);
            this.Buttonstart.TabIndex = 3;
            this.Buttonstart.Text = "开始";
            this.Buttonstart.UseVisualStyleBackColor = true;
            this.Buttonstart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textStartURL
            // 
            this.textStartURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crawlerBindingSource, "StartURL", true));
            this.textStartURL.Location = new System.Drawing.Point(234, 16);
            this.textStartURL.Name = "textStartURL";
            this.textStartURL.Size = new System.Drawing.Size(298, 25);
            this.textStartURL.TabIndex = 2;
            this.textStartURL.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(88, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "结果如下：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标网站：";
            // 
            // Result
            // 
            this.Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.Location = new System.Drawing.Point(0, 117);
            this.Result.Name = "Result";
            this.Result.RowHeadersWidth = 51;
            this.Result.RowTemplate.Height = 27;
            this.Result.Size = new System.Drawing.Size(800, 333);
            this.Result.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crawlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Buttonstart;
        private System.Windows.Forms.TextBox textStartURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Result;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label statelabel;
        private System.Windows.Forms.BindingSource crawlerBindingSource;
        private System.Windows.Forms.TextBox textmax;
        private System.Windows.Forms.Label label3;
    }
}

