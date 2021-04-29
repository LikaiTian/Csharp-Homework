namespace Homework8
{
    partial class Winform
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.export = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.queryOrder = new System.Windows.Forms.Button();
            this.deleteOrder = new System.Windows.Forms.Button();
            this.updateOrder = new System.Windows.Forms.Button();
            this.addOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.export);
            this.splitContainer1.Panel1.Controls.Add(this.import);
            this.splitContainer1.Panel1.Controls.Add(this.queryOrder);
            this.splitContainer1.Panel1.Controls.Add(this.deleteOrder);
            this.splitContainer1.Panel1.Controls.Add(this.updateOrder);
            this.splitContainer1.Panel1.Controls.Add(this.addOrder);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(774, 436);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // export
            // 
            this.export.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.export.Location = new System.Drawing.Point(62, 305);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(110, 35);
            this.export.TabIndex = 5;
            this.export.Text = "导出订单";
            this.export.UseVisualStyleBackColor = true;
            // 
            // import
            // 
            this.import.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.import.Location = new System.Drawing.Point(62, 255);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(110, 35);
            this.import.TabIndex = 4;
            this.import.Text = "导入订单";
            this.import.UseVisualStyleBackColor = true;
            // 
            // queryOrder
            // 
            this.queryOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.queryOrder.Location = new System.Drawing.Point(62, 205);
            this.queryOrder.Name = "queryOrder";
            this.queryOrder.Size = new System.Drawing.Size(110, 35);
            this.queryOrder.TabIndex = 3;
            this.queryOrder.Text = "查询订单";
            this.queryOrder.UseVisualStyleBackColor = true;
            // 
            // deleteOrder
            // 
            this.deleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteOrder.Location = new System.Drawing.Point(62, 155);
            this.deleteOrder.Name = "deleteOrder";
            this.deleteOrder.Size = new System.Drawing.Size(110, 35);
            this.deleteOrder.TabIndex = 2;
            this.deleteOrder.Text = "删除订单";
            this.deleteOrder.UseVisualStyleBackColor = true;
            // 
            // updateOrder
            // 
            this.updateOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateOrder.Location = new System.Drawing.Point(62, 105);
            this.updateOrder.Name = "updateOrder";
            this.updateOrder.Size = new System.Drawing.Size(110, 35);
            this.updateOrder.TabIndex = 1;
            this.updateOrder.Text = "修改订单";
            this.updateOrder.UseVisualStyleBackColor = true;
            // 
            // addOrder
            // 
            this.addOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addOrder.Location = new System.Drawing.Point(62, 55);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(110, 35);
            this.addOrder.TabIndex = 0;
            this.addOrder.Text = "添加订单";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(436, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Homework8.Order);
            // 
            // Winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 436);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Winform";
            this.Text = "Winform";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button queryOrder;
        private System.Windows.Forms.Button deleteOrder;
        private System.Windows.Forms.Button updateOrder;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

