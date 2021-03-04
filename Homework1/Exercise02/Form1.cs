using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");

            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = leftValue.Text != null ? Convert.ToDouble(leftValue.Text) : 0;
            double b = rightValue.Text != null ? Convert.ToDouble(rightValue.Text) : 0;
            double result=0;
            string s = comboBox1.Text;
            switch (s)
            {
                case "+":result = a + b;break;
                case "-":result = a - b;break;
                case "*":result = a * b;break;
                case "/":result = a / b;break;
                default:break;
            }
            resultValue.Text = result.ToString();
        }
    }
}
