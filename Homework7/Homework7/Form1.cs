using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = panel1.CreateGraphics();
            th1 = (int)(Rlength.Value) * Math.PI / 180;
            th2 = (int)(Llength.Value) * Math.PI / 180;
            per1 = (double)Rd.Value;
            per2 = (double)Ld.Value;
            int n = (int)Depth.Value;
            int leng = (int)Length.Value;
            Color c = Color.FromName(comboBox.Text);
            DrawCayLeyTree(n, 200, 310, leng, -Math.PI / 2, c);
            
        }
        void DrawCayLeyTree(int n,double x0,double y0,double leng,double th,Color c)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1, c);

            DrawCayLeyTree(n - 1, x1, y1, per1 * leng, th + th1, c);
            DrawCayLeyTree(n - 1, x1, y1, per2 * leng, th - th2, c);
        }
        void DrawLine(double x0,double y0,double x1,double y1,Color c)
        {
            Pen myPen = new Pen(c);
            graphics.DrawLine(myPen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
