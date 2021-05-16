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
    public partial class GoodEdit : Form
    {
        public OrderDetail Detail { get; set; }
        public Order Order { get; set; }
        public bool Flag { get; set; }
        public GoodEdit(Order order,OrderDetail detail,bool flag)
        {
            InitializeComponent();
            this.Detail = detail;
            this.Order = order;
            this.Flag = flag;
            bindingSource2.Add(new Goods("1", "apple", 100.0));
            bindingSource2.Add(new Goods("2", "egg", 200.0));
            bindingSource2.Add(new Goods("3", "milk", 300.0));
            cbxGoods.DataSource = bindingSource2;
            cbxGoods.DisplayMember = "Name";

            this.txtQuantity.DataBindings.Add("Text", Detail, "Quantity");
            this.cbxGoods.DataBindings.Add("SelectedItem", Detail, "GoodsItem");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Flag)
            {
                if (Order.Details.Count != 0)
                {
                    Detail.DetialId = Order.Details.Count;
                }
                else
                {
                    Detail.DetialId = 0;
                }
                Order.AddItem(Detail);
            }
            this.Close();
        }
    }
}
