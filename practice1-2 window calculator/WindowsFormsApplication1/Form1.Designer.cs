namespace WindowsFormsApplication1
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
            this.Button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Num1 = new System.Windows.Forms.Label();
            this.Label_Num2 = new System.Windows.Forms.Label();
            this.Label_Result = new System.Windows.Forms.Label();
            this.ComboBox_Sign = new System.Windows.Forms.ComboBox();
            this.TextBox_Num1 = new System.Windows.Forms.TextBox();
            this.TextBox_Num2 = new System.Windows.Forms.TextBox();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(218, 214);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(119, 72);
            this.Button_Start.TabIndex = 0;
            this.Button_Start.Text = "开始计算";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Num1
            // 
            this.Label_Num1.AutoSize = true;
            this.Label_Num1.Location = new System.Drawing.Point(104, 84);
            this.Label_Num1.Name = "Label_Num1";
            this.Label_Num1.Size = new System.Drawing.Size(43, 16);
            this.Label_Num1.TabIndex = 2;
            this.Label_Num1.Text = "Num1";
            this.Label_Num1.Click += new System.EventHandler(this.Label_Num1_Click);
            // 
            // Label_Num2
            // 
            this.Label_Num2.AutoSize = true;
            this.Label_Num2.Location = new System.Drawing.Point(311, 84);
            this.Label_Num2.Name = "Label_Num2";
            this.Label_Num2.Size = new System.Drawing.Size(43, 16);
            this.Label_Num2.TabIndex = 4;
            this.Label_Num2.Text = "Num2";
            this.Label_Num2.Click += new System.EventHandler(this.Label_Num2_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(436, 84);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(46, 16);
            this.Label_Result.TabIndex = 5;
            this.Label_Result.Text = "Result";
            this.Label_Result.Click += new System.EventHandler(this.Label_Result_Click);
            // 
            // ComboBox_Sign
            // 
            this.ComboBox_Sign.DisplayMember = "+";
            this.ComboBox_Sign.DropDownHeight = 130;
            this.ComboBox_Sign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Sign.FormattingEnabled = true;
            this.ComboBox_Sign.IntegralHeight = false;
            this.ComboBox_Sign.Items.AddRange(new object[] {
            "-",
            "*",
            "/",
            "+"});
            this.ComboBox_Sign.Location = new System.Drawing.Point(197, 117);
            this.ComboBox_Sign.Name = "ComboBox_Sign";
            this.ComboBox_Sign.Size = new System.Drawing.Size(53, 24);
            this.ComboBox_Sign.Sorted = true;
            this.ComboBox_Sign.TabIndex = 6;
            this.ComboBox_Sign.Tag = "";
            this.ComboBox_Sign.ValueMember = "0";
            // 
            // TextBox_Num1
            // 
            this.TextBox_Num1.Location = new System.Drawing.Point(98, 117);
            this.TextBox_Num1.Name = "TextBox_Num1";
            this.TextBox_Num1.Size = new System.Drawing.Size(59, 22);
            this.TextBox_Num1.TabIndex = 7;
            // 
            // TextBox_Num2
            // 
            this.TextBox_Num2.Location = new System.Drawing.Point(295, 117);
            this.TextBox_Num2.Name = "TextBox_Num2";
            this.TextBox_Num2.Size = new System.Drawing.Size(59, 22);
            this.TextBox_Num2.TabIndex = 8;
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(393, 117);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.ReadOnly = true;
            this.TextBox_Result.Size = new System.Drawing.Size(135, 22);
            this.TextBox_Result.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 348);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.TextBox_Num2);
            this.Controls.Add(this.TextBox_Num1);
            this.Controls.Add(this.Label_Num1);
            this.Controls.Add(this.Label_Num2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.ComboBox_Sign);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Num1;
        private System.Windows.Forms.Label Label_Num2;
        private System.Windows.Forms.Label Label_Result;
        private System.Windows.Forms.ComboBox ComboBox_Sign;
        private System.Windows.Forms.TextBox TextBox_Num1;
        private System.Windows.Forms.TextBox TextBox_Num2;
        private System.Windows.Forms.TextBox TextBox_Result;
    }
}

