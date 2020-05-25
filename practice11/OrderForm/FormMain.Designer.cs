namespace OrderForm
{
    partial class FormMain
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
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.cbField = new System.Windows.Forms.ComboBox();
      this.txtValue = new System.Windows.Forms.TextBox();
      this.btnQuery = new System.Windows.Forms.Button();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnExport = new System.Windows.Forms.Button();
      this.btnImport = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.panel1 = new System.Windows.Forms.Panel();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.dbvOrders = new System.Windows.Forms.DataGridView();
      this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dbvItems = new System.Windows.Forms.DataGridView();
      this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.flowLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.cbField);
      this.flowLayoutPanel1.Controls.Add(this.txtValue);
      this.flowLayoutPanel1.Controls.Add(this.btnQuery);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
      this.flowLayoutPanel1.Size = new System.Drawing.Size(846, 50);
      this.flowLayoutPanel1.TabIndex = 0;
      // 
      // cbField
      // 
      this.cbField.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.cbField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbField.FormattingEnabled = true;
      this.cbField.Items.AddRange(new object[] {
            "全部订单",
            "ID",
            "客户名",
            "货物名",
            "价格大于"});
      this.cbField.Location = new System.Drawing.Point(13, 14);
      this.cbField.Name = "cbField";
      this.cbField.Size = new System.Drawing.Size(121, 20);
      this.cbField.TabIndex = 0;
      // 
      // txtValue
      // 
      this.txtValue.Location = new System.Drawing.Point(140, 13);
      this.txtValue.Name = "txtValue";
      this.txtValue.Size = new System.Drawing.Size(245, 21);
      this.txtValue.TabIndex = 1;
      // 
      // btnQuery
      // 
      this.btnQuery.Location = new System.Drawing.Point(391, 13);
      this.btnQuery.Name = "btnQuery";
      this.btnQuery.Size = new System.Drawing.Size(75, 23);
      this.btnQuery.TabIndex = 2;
      this.btnQuery.Text = "查询";
      this.btnQuery.UseVisualStyleBackColor = true;
      this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Controls.Add(this.btnAdd);
      this.flowLayoutPanel2.Controls.Add(this.btnModify);
      this.flowLayoutPanel2.Controls.Add(this.btnDelete);
      this.flowLayoutPanel2.Controls.Add(this.btnExport);
      this.flowLayoutPanel2.Controls.Add(this.btnImport);
      this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 50);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.flowLayoutPanel2.Size = new System.Drawing.Size(846, 34);
      this.flowLayoutPanel2.TabIndex = 1;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(13, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "添加订单";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(94, 3);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(75, 23);
      this.btnModify.TabIndex = 4;
      this.btnModify.Text = "修改订单";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(175, 3);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 23);
      this.btnDelete.TabIndex = 1;
      this.btnDelete.Text = "删除订单";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnExport
      // 
      this.btnExport.Location = new System.Drawing.Point(256, 3);
      this.btnExport.Name = "btnExport";
      this.btnExport.Size = new System.Drawing.Size(75, 23);
      this.btnExport.TabIndex = 2;
      this.btnExport.Text = "导出订单";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // btnImport
      // 
      this.btnImport.Location = new System.Drawing.Point(337, 3);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(75, 23);
      this.btnImport.TabIndex = 3;
      this.btnImport.Text = "导入订单";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Location = new System.Drawing.Point(0, 425);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(846, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.splitContainer1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 84);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(10);
      this.panel1.Size = new System.Drawing.Size(846, 341);
      this.panel1.TabIndex = 3;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(10, 10);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.dbvOrders);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.dbvItems);
      this.splitContainer1.Size = new System.Drawing.Size(826, 321);
      this.splitContainer1.SplitterDistance = 419;
      this.splitContainer1.TabIndex = 5;
      // 
      // dbvOrders
      // 
      this.dbvOrders.AllowUserToAddRows = false;
      this.dbvOrders.AutoGenerateColumns = false;
      this.dbvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dbvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.customerNameDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
      this.dbvOrders.DataSource = this.orderBindingSource;
      this.dbvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dbvOrders.Location = new System.Drawing.Point(0, 0);
      this.dbvOrders.Name = "dbvOrders";
      this.dbvOrders.RowTemplate.Height = 23;
      this.dbvOrders.Size = new System.Drawing.Size(419, 321);
      this.dbvOrders.TabIndex = 6;
      this.dbvOrders.DoubleClick += new System.EventHandler(this.dbvOrders_DoubleClick);
      // 
      // orderBindingSource
      // 
      this.orderBindingSource.DataSource = typeof(OrderApp.Order);
      // 
      // dbvItems
      // 
      this.dbvItems.AllowUserToAddRows = false;
      this.dbvItems.AutoGenerateColumns = false;
      this.dbvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dbvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.UnitPrice,
            this.totalPriceDataGridViewTextBoxColumn1});
      this.dbvItems.DataSource = this.itemsBindingSource;
      this.dbvItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dbvItems.Location = new System.Drawing.Point(0, 0);
      this.dbvItems.Name = "dbvItems";
      this.dbvItems.RowTemplate.Height = 23;
      this.dbvItems.Size = new System.Drawing.Size(403, 321);
      this.dbvItems.TabIndex = 0;
      // 
      // indexDataGridViewTextBoxColumn
      // 
      this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
      this.indexDataGridViewTextBoxColumn.HeaderText = "序号";
      this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
      // 
      // goodsNameDataGridViewTextBoxColumn
      // 
      this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
      this.goodsNameDataGridViewTextBoxColumn.HeaderText = "货物";
      this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
      this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
      this.dataGridViewTextBoxColumn2.HeaderText = "数量";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // UnitPrice
      // 
      this.UnitPrice.DataPropertyName = "UnitPrice";
      this.UnitPrice.HeaderText = "单价";
      this.UnitPrice.Name = "UnitPrice";
      this.UnitPrice.ReadOnly = true;
      // 
      // totalPriceDataGridViewTextBoxColumn1
      // 
      this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
      this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
      this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
      this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // itemsBindingSource
      // 
      this.itemsBindingSource.DataMember = "Items";
      this.itemsBindingSource.DataSource = this.orderBindingSource;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(456, 426);
      this.textBox1.Margin = new System.Windows.Forms.Padding(2);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(76, 21);
      this.textBox1.TabIndex = 3;
      // 
      // ID
      // 
      this.ID.DataPropertyName = "Id";
      this.ID.HeaderText = "订单ID";
      this.ID.Name = "ID";
      // 
      // customerNameDataGridViewTextBoxColumn
      // 
      this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
      this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户";
      this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
      this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // createTimeDataGridViewTextBoxColumn
      // 
      this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
      this.createTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
      this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
      // 
      // totalPriceDataGridViewTextBoxColumn
      // 
      this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
      this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
      this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
      this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(846, 447);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.flowLayoutPanel2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Name = "FormMain";
      this.Text = "订单管理";
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dbvOrders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dbvItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbField;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dbvOrders;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.DataGridViewTextBoxColumn goodsDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridView dbvItems;
    private System.Windows.Forms.BindingSource orderBindingSource;
    private System.Windows.Forms.BindingSource itemsBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
  }
}

