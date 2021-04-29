namespace homework08_1
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.change_btn = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.add_btn = new System.Windows.Forms.Button();
            this.query_btn = new System.Windows.Forms.Button();
            this.queryBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSource = new System.Windows.Forms.BindingSource(this.components);
            this.import_btn = new System.Windows.Forms.Button();
            this.export_btn = new System.Windows.Forms.Button();
            this.show_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maxBox);
            this.panel1.Controls.Add(this.minBox);
            this.panel1.Controls.Add(this.change_btn);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.query_btn);
            this.panel1.Controls.Add(this.queryBox1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
            this.panel1.TabIndex = 0;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(821, 40);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(139, 48);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "删除订单";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "一";
            // 
            // maxBox
            // 
            this.maxBox.Location = new System.Drawing.Point(441, 12);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(37, 25);
            this.maxBox.TabIndex = 9;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(371, 12);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(37, 25);
            this.minBox.TabIndex = 8;
            // 
            // change_btn
            // 
            this.change_btn.Location = new System.Drawing.Point(666, 38);
            this.change_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(139, 48);
            this.change_btn.TabIndex = 7;
            this.change_btn.Text = "修改订单";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(277, 14);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(88, 19);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "订单金额";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(197, 14);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "顾客名";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(117, 15);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "商品名";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 15);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "订单号";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(516, 40);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(139, 48);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "添加订单";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // query_btn
            // 
            this.query_btn.Location = new System.Drawing.Point(371, 39);
            this.query_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(136, 48);
            this.query_btn.TabIndex = 1;
            this.query_btn.Text = "查询订单";
            this.query_btn.UseVisualStyleBackColor = true;
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // queryBox1
            // 
            this.queryBox1.Location = new System.Drawing.Point(39, 40);
            this.queryBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryBox1.Multiline = true;
            this.queryBox1.Name = "queryBox1";
            this.queryBox1.Size = new System.Drawing.Size(327, 46);
            this.queryBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.orderView);
            this.panel2.Location = new System.Drawing.Point(13, 149);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 480);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.total});
            this.dataGridView1.DataSource = this.orderDetailSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 221);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(971, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 185;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "购买数量";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.Width = 200;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "合计";
            this.total.Name = "total";
            this.total.Width = 150;
            // 
            // orderDetailSource
            // 
            this.orderDetailSource.DataSource = typeof(homework06_1.OrderDetails);
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.AutoGenerateColumns = false;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customer,
            this.totalMoney});
            this.orderView.DataSource = this.orderSource;
            this.orderView.Location = new System.Drawing.Point(0, 0);
            this.orderView.Margin = new System.Windows.Forms.Padding(4);
            this.orderView.Name = "orderView";
            this.orderView.RowTemplate.Height = 23;
            this.orderView.Size = new System.Drawing.Size(971, 212);
            this.orderView.TabIndex = 0;
            this.orderView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderView_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 200;
            // 
            // customer
            // 
            this.customer.DataPropertyName = "customer";
            this.customer.HeaderText = "客户";
            this.customer.Name = "customer";
            this.customer.Width = 250;
            // 
            // totalMoney
            // 
            this.totalMoney.DataPropertyName = "totalMoney";
            this.totalMoney.HeaderText = "商品总价";
            this.totalMoney.Name = "totalMoney";
            this.totalMoney.Width = 235;
            // 
            // orderSource
            // 
            this.orderSource.DataSource = typeof(homework06_1.Order);
            // 
            // import_btn
            // 
            this.import_btn.Location = new System.Drawing.Point(211, 652);
            this.import_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.import_btn.Name = "import_btn";
            this.import_btn.Size = new System.Drawing.Size(123, 48);
            this.import_btn.TabIndex = 2;
            this.import_btn.Text = "导入订单";
            this.import_btn.UseVisualStyleBackColor = true;
            this.import_btn.Click += new System.EventHandler(this.import_btn_Click);
            // 
            // export_btn
            // 
            this.export_btn.Location = new System.Drawing.Point(666, 652);
            this.export_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.export_btn.Name = "export_btn";
            this.export_btn.Size = new System.Drawing.Size(123, 48);
            this.export_btn.TabIndex = 3;
            this.export_btn.Text = "导出订单";
            this.export_btn.UseVisualStyleBackColor = true;
            this.export_btn.Click += new System.EventHandler(this.export_btn_Click);
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(401, 652);
            this.show_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(196, 48);
            this.show_btn.TabIndex = 4;
            this.show_btn.Text = "显示所有订单";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 714);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.export_btn);
            this.Controls.Add(this.import_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox queryBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button query_btn;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button import_btn;
        private System.Windows.Forms.Button export_btn;
        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.BindingSource orderSource;
        private System.Windows.Forms.BindingSource orderDetailSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoney;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button show_btn;
    }
}

