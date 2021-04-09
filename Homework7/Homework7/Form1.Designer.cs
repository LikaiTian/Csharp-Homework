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
            this.pen = new System.Windows.Forms.TextBox();
            this.th02 = new System.Windows.Forms.TextBox();
            this.th01 = new System.Windows.Forms.TextBox();
            this.per02 = new System.Windows.Forms.TextBox();
            this.per01 = new System.Windows.Forms.TextBox();
            this.Leng = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pen);
            this.groupBox1.Controls.Add(this.th02);
            this.groupBox1.Controls.Add(this.th01);
            this.groupBox1.Controls.Add(this.per02);
            this.groupBox1.Controls.Add(this.per01);
            this.groupBox1.Controls.Add(this.Leng);
            this.groupBox1.Controls.Add(this.N);
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
            // pen
            // 
            this.pen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pen.Location = new System.Drawing.Point(109, 355);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(152, 25);
            this.pen.TabIndex = 6;
            // 
            // th02
            // 
            this.th02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th02.Location = new System.Drawing.Point(109, 300);
            this.th02.Name = "th02";
            this.th02.Size = new System.Drawing.Size(152, 25);
            this.th02.TabIndex = 5;
            // 
            // th01
            // 
            this.th01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.th01.Location = new System.Drawing.Point(109, 245);
            this.th01.Name = "th01";
            this.th01.Size = new System.Drawing.Size(152, 25);
            this.th01.TabIndex = 4;
            // 
            // per02
            // 
            this.per02.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per02.Location = new System.Drawing.Point(109, 190);
            this.per02.Name = "per02";
            this.per02.Size = new System.Drawing.Size(152, 25);
            this.per02.TabIndex = 3;
            // 
            // per01
            // 
            this.per01.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.per01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.per01.Location = new System.Drawing.Point(109, 135);
            this.per01.Name = "per01";
            this.per01.Size = new System.Drawing.Size(152, 25);
            this.per01.TabIndex = 2;
            // 
            // Leng
            // 
            this.Leng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Leng.Location = new System.Drawing.Point(109, 80);
            this.Leng.Name = "Leng";
            this.Leng.Size = new System.Drawing.Size(152, 25);
            this.Leng.TabIndex = 2;
            // 
            // N
            // 
            this.N.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.N.Location = new System.Drawing.Point(109, 25);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(152, 25);
            this.N.TabIndex = 1;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Leng;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox per01;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pen;
        private System.Windows.Forms.TextBox th02;
        private System.Windows.Forms.TextBox th01;
        private System.Windows.Forms.TextBox per02;
        private System.Windows.Forms.Panel panel1;
    }
}

