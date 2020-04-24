namespace CrawlerForm {
  partial class Form1 {
    /// <summary>
    /// 必需的设计器变量。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有正在使用的资源。
    /// </summary>
    /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent() {
      this.dgvResult = new System.Windows.Forms.DataGridView();
      this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.txtUrl = new System.Windows.Forms.TextBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvResult
      // 
      this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.URL,
            this.status});
      this.dgvResult.Location = new System.Drawing.Point(25, 95);
      this.dgvResult.Name = "dgvResult";
      this.dgvResult.RowTemplate.Height = 23;
      this.dgvResult.Size = new System.Drawing.Size(1015, 454);
      this.dgvResult.TabIndex = 3;
      // 
      // index
      // 
      this.index.DataPropertyName = "Index";
      this.index.HeaderText = "序号";
      this.index.Name = "index";
      // 
      // URL
      // 
      this.URL.DataPropertyName = "URL";
      this.URL.HeaderText = "URL";
      this.URL.Name = "URL";
      this.URL.Width = 500;
      // 
      // status
      // 
      this.status.DataPropertyName = "Status";
      this.status.HeaderText = "状态";
      this.status.Name = "status";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 552);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1063, 22);
      this.statusStrip1.TabIndex = 4;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Controls.Add(this.txtUrl);
      this.flowLayoutPanel1.Controls.Add(this.btnStart);
      this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
      this.flowLayoutPanel1.Size = new System.Drawing.Size(1063, 61);
      this.flowLayoutPanel1.TabIndex = 5;
      // 
      // txtUrl
      // 
      this.txtUrl.Location = new System.Drawing.Point(23, 23);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.Size = new System.Drawing.Size(412, 21);
      this.txtUrl.TabIndex = 4;
      this.txtUrl.Text = "http://www.cnblogs.com/dstang2000/";
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(441, 23);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "开始";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(23, 68);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(0, 12);
      this.lblInfo.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1063, 574);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.dgvResult);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView dgvResult;
    private System.Windows.Forms.DataGridViewTextBoxColumn index;
    private System.Windows.Forms.DataGridViewTextBoxColumn URL;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Label lblInfo;
  }
}

