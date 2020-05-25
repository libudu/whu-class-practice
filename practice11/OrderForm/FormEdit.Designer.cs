namespace OrderForm
{
    partial class FormEdit
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
      this.components = new System.ComponentModel.Container();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.cbxCustomer = new System.Windows.Forms.ComboBox();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtOrderId = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblCreateTime = new System.Windows.Forms.Label();
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnDeleteItem = new System.Windows.Forms.Button();
      this.btnEditItem = new System.Windows.Forms.Button();
      this.btnAddItem = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dgvItems = new System.Windows.Forms.DataGridView();
      this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.tableLayoutPanel1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(621, 120);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "基本信息";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 559F));
      this.tableLayoutPanel1.Controls.Add(this.cbxCustomer, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.txtOrderId, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblCreateTime, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 100);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // cbxCustomer
      // 
      this.cbxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.orderBindingSource, "Customer", true));
      this.cbxCustomer.DataSource = this.customerBindingSource;
      this.cbxCustomer.DisplayMember = "Name";
      this.cbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.cbxCustomer.FormattingEnabled = true;
      this.cbxCustomer.Location = new System.Drawing.Point(103, 36);
      this.cbxCustomer.Name = "cbxCustomer";
      this.cbxCustomer.Size = new System.Drawing.Size(341, 20);
      this.cbxCustomer.TabIndex = 10;
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(OrderApp.Order);
      // 
      // customerBindingSource
      // 
      this.customerBindingSource.DataSource = typeof(OrderApp.Customer);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Right;
      this.label2.Location = new System.Drawing.Point(56, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 33);
      this.label2.TabIndex = 7;
      this.label2.Text = "订单号";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Right;
      this.label1.Location = new System.Drawing.Point(68, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 33);
      this.label1.TabIndex = 6;
      this.label1.Text = "客户";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtOrderId
      // 
      this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Id", true));
      this.txtOrderId.Location = new System.Drawing.Point(103, 3);
      this.txtOrderId.Name = "txtOrderId";
      this.txtOrderId.Size = new System.Drawing.Size(341, 21);
      this.txtOrderId.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(45, 77);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 12);
      this.label3.TabIndex = 11;
      this.label3.Text = "下单时间";
      // 
      // lblCreateTime
      // 
      this.lblCreateTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblCreateTime.AutoSize = true;
      this.lblCreateTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CreateTime", true));
      this.lblCreateTime.Location = new System.Drawing.Point(102, 77);
      this.lblCreateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblCreateTime.Name = "lblCreateTime";
      this.lblCreateTime.Size = new System.Drawing.Size(59, 12);
      this.lblCreateTime.TabIndex = 12;
      this.lblCreateTime.Text = "2020-4-10";
      // 
      // itemsBindingSource
      // 
      this.itemsBindingSource.DataMember = "Items";
      this.itemsBindingSource.DataSource = this.orderBindingSource;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnDeleteItem);
      this.panel1.Controls.Add(this.btnEditItem);
      this.panel1.Controls.Add(this.btnAddItem);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(5, 391);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(621, 38);
      this.panel1.TabIndex = 3;
      // 
      // btnDeleteItem
      // 
      this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDeleteItem.Location = new System.Drawing.Point(187, 6);
      this.btnDeleteItem.Name = "btnDeleteItem";
      this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
      this.btnDeleteItem.TabIndex = 7;
      this.btnDeleteItem.Text = "删除明细";
      this.btnDeleteItem.UseVisualStyleBackColor = true;
      this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
      // 
      // btnEditItem
      // 
      this.btnEditItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnEditItem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnEditItem.Location = new System.Drawing.Point(106, 6);
      this.btnEditItem.Name = "btnEditItem";
      this.btnEditItem.Size = new System.Drawing.Size(75, 23);
      this.btnEditItem.TabIndex = 6;
      this.btnEditItem.Text = "修改明细";
      this.btnEditItem.UseVisualStyleBackColor = true;
      this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
      // 
      // btnAddItem
      // 
      this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddItem.Location = new System.Drawing.Point(25, 6);
      this.btnAddItem.Name = "btnAddItem";
      this.btnAddItem.Size = new System.Drawing.Size(75, 23);
      this.btnAddItem.TabIndex = 5;
      this.btnAddItem.Text = "添加明细";
      this.btnAddItem.UseVisualStyleBackColor = true;
      this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
      // 
      // btnSave
      // 
      this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnSave.BackColor = System.Drawing.Color.WhiteSmoke;
      this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Location = new System.Drawing.Point(479, 6);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(126, 23);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "保存订单";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dgvItems);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Location = new System.Drawing.Point(5, 125);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(621, 266);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "订单明细";
      // 
      // dgvItems
      // 
      this.dgvItems.AllowUserToAddRows = false;
      this.dgvItems.AutoGenerateColumns = false;
      this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Goods,
            this.quantityDataGridViewTextBoxColumn,
            this.UnitPrice,
            this.Amount});
      this.dgvItems.DataSource = this.itemsBindingSource;
      this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvItems.Location = new System.Drawing.Point(3, 17);
      this.dgvItems.Name = "dgvItems";
      this.dgvItems.ReadOnly = true;
      this.dgvItems.RowTemplate.Height = 23;
      this.dgvItems.Size = new System.Drawing.Size(615, 246);
      this.dgvItems.TabIndex = 0;
      this.dgvItems.DoubleClick += new System.EventHandler(this.dgvItems_DoubleClick);
      // 
      // Index
      // 
      this.Index.DataPropertyName = "Index";
      this.Index.HeaderText = "序号";
      this.Index.Name = "Index";
      this.Index.ReadOnly = true;
      // 
      // Goods
      // 
      this.Goods.DataPropertyName = "GoodsName";
      this.Goods.HeaderText = "货物";
      this.Goods.Name = "Goods";
      this.Goods.ReadOnly = true;
      this.Goods.Width = 200;
      // 
      // quantityDataGridViewTextBoxColumn
      // 
      this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
      this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
      this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
      this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // UnitPrice
      // 
      this.UnitPrice.DataPropertyName = "UnitPrice";
      this.UnitPrice.HeaderText = "单价";
      this.UnitPrice.Name = "UnitPrice";
      this.UnitPrice.ReadOnly = true;
      // 
      // Amount
      // 
      this.Amount.DataPropertyName = "TotalPrice";
      this.Amount.HeaderText = "总价";
      this.Amount.Name = "Amount";
      this.Amount.ReadOnly = true;
      // 
      // FormEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(631, 434);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.groupBox1);
      this.MaximumSize = new System.Drawing.Size(1000, 472);
      this.MinimumSize = new System.Drawing.Size(500, 472);
      this.Name = "FormEdit";
      this.Padding = new System.Windows.Forms.Padding(5);
      this.Text = "修改订单";
      this.groupBox1.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.panel1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnAddItem;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.ComboBox cbxCustomer;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtOrderId;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblCreateTime;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridView dgvItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn Index;
    private System.Windows.Forms.DataGridViewTextBoxColumn Goods;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    private System.Windows.Forms.Button btnEditItem;
    private System.Windows.Forms.Button btnDeleteItem;
  }
}