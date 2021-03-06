namespace calculator02
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
            this.opBox = new System.Windows.Forms.ComboBox();
            this.inputBox1 = new System.Windows.Forms.TextBox();
            this.inputBox2 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opBox
            // 
            this.opBox.FormattingEnabled = true;
            this.opBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.opBox.Location = new System.Drawing.Point(277, 144);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(67, 20);
            this.opBox.TabIndex = 0;
            // 
            // inputBox1
            // 
            this.inputBox1.Location = new System.Drawing.Point(182, 144);
            this.inputBox1.Name = "inputBox1";
            this.inputBox1.Size = new System.Drawing.Size(80, 21);
            this.inputBox1.TabIndex = 1;
            // 
            // inputBox2
            // 
            this.inputBox2.Location = new System.Drawing.Point(362, 143);
            this.inputBox2.Name = "inputBox2";
            this.inputBox2.Size = new System.Drawing.Size(80, 21);
            this.inputBox2.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(535, 143);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 21);
            this.resultBox.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(454, 141);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 24);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "计算";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox2);
            this.Controls.Add(this.inputBox1);
            this.Controls.Add(this.opBox);
            this.Name = "Form1";
            this.Text = "Cauculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox opBox;
        private System.Windows.Forms.TextBox inputBox1;
        private System.Windows.Forms.TextBox inputBox2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calculate;
    }
}

