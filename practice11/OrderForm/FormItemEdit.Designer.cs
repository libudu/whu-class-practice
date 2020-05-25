namespace OrderForm {
  partial class FormItemEdit {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.txtQuantity = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63662F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36338F));
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 107);
      this.tableLayoutPanel1.TabIndex = 10;
      this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Dock = System.Windows.Forms.DockStyle.Right;
      this.label3.Location = new System.Drawing.Point(68, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(29, 53);
      this.label3.TabIndex = 1;
      this.label3.Text = "货物";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // comboBox1
      // 
      this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.ItemBindingSource, "GoodsItem", true));
      this.comboBox1.DataSource = this.goodsBindingSource;
      this.comboBox1.DisplayMember = "Name";
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(102, 16);
      this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(360, 20);
      this.comboBox1.TabIndex = 2;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // txtQuantity
      // 
      this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ItemBindingSource, "Quantity", true));
      this.txtQuantity.Location = new System.Drawing.Point(102, 69);
      this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtQuantity.Name = "txtQuantity";
      this.txtQuantity.Size = new System.Drawing.Size(360, 21);
      this.txtQuantity.TabIndex = 10;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 13;
      this.label2.Text = "数量";
      // 
      // btnOK
      // 
      this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(180, 140);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(114, 23);
      this.btnOK.TabIndex = 11;
      this.btnOK.Text = "确定";
      this.btnOK.UseVisualStyleBackColor = true;
      // 
      // ItemBindingSource
      // 
      this.ItemBindingSource.DataSource = typeof(OrderApp.OrderItem);
      // 
      // goodsBindingSource
      // 
      this.goodsBindingSource.DataSource = typeof(OrderApp.Goods);
      // 
      // FormItemEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 195);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximumSize = new System.Drawing.Size(500, 250);
      this.Name = "FormItemEdit";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "订单明细";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ItemBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.BindingSource ItemBindingSource;
    private System.Windows.Forms.BindingSource goodsBindingSource;
  }
}