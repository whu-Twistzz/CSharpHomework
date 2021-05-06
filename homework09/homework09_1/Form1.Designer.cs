namespace homework09_1
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(90, 67);
            this.urlBox.Margin = new System.Windows.Forms.Padding(2);
            this.urlBox.Multiline = true;
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(476, 19);
            this.urlBox.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(591, 63);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 27);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "开始";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.Column2,
            this.Column3});
            this.resultGridView.Location = new System.Drawing.Point(12, 129);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowTemplate.Height = 23;
            this.resultGridView.Size = new System.Drawing.Size(706, 390);
            this.resultGridView.TabIndex = 3;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "Index";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "URL";
            this.Column2.HeaderText = "URL";
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Status";
            this.Column3.HeaderText = "状态";
            this.Column3.Name = "Column3";
            this.Column3.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 531);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.urlBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

