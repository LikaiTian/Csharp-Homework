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

    public partial class addOrder : Form
    {
        static int no = 0;
        public Order order { get; set; } = new Order();
        public string GoodsName { get; set; }
        public int Amount { get; set; }
        public string CName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public addOrder()
        {
            InitializeComponent();
        }
        private void addDetial_Click(object sender, EventArgs e)
        {
            
            goodsName.DataBindings.Add("SelectedItem", this, "GoodsName");
            goodsAmount.DataBindings.Add("Text", this, "Amount");
            double price = 0;
            switch (this.GoodsName) {
                case "apple":
                    price = 3.5;
                    break;
                case "milk":
                    price = 60;
                    break;
                case "egg":
                    price = 5;
                    break;
                case "melon":
                    price = 1.2;
                    break;
            }
            OrderDetails orderDetail = new OrderDetails(GoodsName, price, Amount);
            order.AddDetails(orderDetail);
            //new Form("订单明细添加成功！").ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerName.DataBindings.Add("Text", this, "CName");
            customerAge.DataBindings.Add("Text", this, "Age");
            customerSex.DataBindings.Add("Text", this, "Sex");
            address.DataBindings.Add("Text", this, "Address");
            order.Customer = new Customer(CName, Age, Sex);
            order.ID = (++no) + "";
            order.OrderTime = DateTime.Now;
            order.Address = Address;
            for (int i = 0; i < order.List.Count; i++)
            {
                order.TotalAmount += order.List[i].Amount * order.List[i].Price;
            }
            Winform w = new Winform();
        }


    }
}
