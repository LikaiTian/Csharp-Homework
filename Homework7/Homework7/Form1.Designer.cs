namespace Homework7
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Depth = new System.Windows.Forms.NumericUpDown();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.Rd = new System.Windows.Forms.NumericUpDown();
            this.Ld = new System.Windows.Forms.NumericUpDown();
            this.Rlength = new System.Windows.Forms.NumericUpDown();
            this.Llength = new System.Windows.Forms.NumericUpDown();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rlength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llength)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.Llength);
            this.groupBox1.Controls.Add(this.Rlength);
            this.groupBox1.Controls.Add(this.Ld);
            this.groupBox1.Controls.Add(this.Rd);
            this.groupBox1.Controls.Add(this.Length);
            this.groupBox1.Controls.Add(this.Depth);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(540, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 477);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "画笔颜色";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "左分支长度";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "右分支长度";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "左分支长度比";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "右分支长度比";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "主干长度";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "递归深度";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 437);
            this.panel1.TabIndex = 2;
            // 
            // Depth
            // 
            this.Depth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Depth.Location = new System.Drawing.Point(118, 33);
            this.Depth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(120, 25);
            this.Depth.TabIndex = 14;
            this.Depth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Length
            // 
            this.Length.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Length.Location = new System.Drawing.Point(118, 87);
            this.Length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(120, 25);
            this.Length.TabIndex = 15;
            this.Length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Rd
            // 
            this.Rd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rd.DecimalPlaces = 1;
            this.Rd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Rd.Location = new System.Drawing.Point(118, 141);
            this.Rd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.Rd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Rd.Name = "Rd";
            this.Rd.Size = new System.Drawing.Size(120, 25);
            this.Rd.TabIndex = 16;
            this.Rd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Ld
            // 
            this.Ld.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ld.DecimalPlaces = 1;
            this.Ld.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Ld.Location = new System.Drawing.Point(118, 195);
            this.Ld.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.Ld.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Ld.Name = "Ld";
            this.Ld.Size = new System.Drawing.Size(120, 25);
            this.Ld.TabIndex = 17;
            this.Ld.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // Rlength
            // 
            this.Rlength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Rlength.Location = new System.Drawing.Point(118, 249);
            this.Rlength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Rlength.Name = "Rlength";
            this.Rlength.Size = new System.Drawing.Size(120, 25);
            this.Rlength.TabIndex = 18;
            this.Rlength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Llength
            // 
            this.Llength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Llength.Location = new System.Drawing.Point(118, 303);
            this.Llength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Llength.Name = "Llength";
            this.Llength.Size = new System.Drawing.Size(120, 25);
            this.Llength.TabIndex = 19;
            this.Llength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox
            // 
            this.comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Black",
            "Yellow",
            "Pink",
            "Green"});
            this.comboBox.Location = new System.Drawing.Point(117, 359);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 23);
            this.comboBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rlength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Llength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Rd;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.NumericUpDown Depth;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.NumericUpDown Llength;
        private System.Windows.Forms.NumericUpDown Rlength;
        private System.Windows.Forms.NumericUpDown Ld;
    }
}

