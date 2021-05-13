namespace Homework8
{
    partial class FormDetailEdit
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
            this.bdsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.bdsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbxGoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsDetail
            // 
            this.bdsDetail.DataSource = typeof(Homework8.OrderDetail);
            // 
            // bdsGoods
            // 
            this.bdsGoods.DataSource = typeof(Homework8.Goods);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(240, 175);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(152, 29);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDetail, "Quantity", true));
            this.txtQuantity.Location = new System.Drawing.Point(138, 103);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(478, 25);
            this.txtQuantity.TabIndex = 10;
            // 
            // cbxGoods
            // 
            this.cbxGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGoods.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bdsDetail, "GoodsItem", true));
            this.cbxGoods.DataSource = this.bdsGoods;
            this.cbxGoods.DisplayMember = "Name";
            this.cbxGoods.FormattingEnabled = true;
            this.cbxGoods.Location = new System.Drawing.Point(138, 33);
            this.cbxGoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGoods.Name = "cbxGoods";
            this.cbxGoods.Size = new System.Drawing.Size(478, 23);
            this.cbxGoods.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "货品";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "数量";
            // 
            // FormDetailEdit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbxGoods);
            this.Controls.Add(this.txtQuantity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(661, 301);
            this.Name = "FormDetailEdit";
            this.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.Text = "订单明细";
            ((System.ComponentModel.ISupportInitialize)(this.bdsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.BindingSource bdsDetail;
        private System.Windows.Forms.BindingSource bdsGoods;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbxGoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}