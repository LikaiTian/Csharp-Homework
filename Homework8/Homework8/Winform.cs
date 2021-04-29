using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework8
{
    public partial class Winform : Form
    {
        OrderService orderService = new OrderService();
        
        public Winform()
        {
            InitializeComponent();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            addOrder addEx = new addOrder();
            addEx.ShowDialog();
            bindingSource1.Add(addEx.order);
        }
    }
}
