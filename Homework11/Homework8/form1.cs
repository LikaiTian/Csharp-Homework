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
    public partial class form1 : Form
    {
        OrderService orderService;
        public String QueryText { get; set; }
        public form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            txtQuery.DataBindings.Add("Text", this, "QueryText");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(new Order(), true, orderService);
            addOrder.ShowDialog();
            Reflash();
        }

        public void Reflash()
        {
            //更新一下信息
            using(var db = new OrderContext())
            {
                bindingSource1.DataSource = db.Orders.ToList();
                bindingSource1.ResetBindings(false);
            }
                
            
        }
        //编辑选中的订单
        private void btnModify_Click(object sender, EventArgs e)
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单修改");
            }
            else
            {
                AddOrder form = new AddOrder(order, false, orderService);
                form.ShowDialog();
                Reflash();
            }
           
        }
        //删除选中的订单
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单删除");
            }
            else
            {
                orderService.RemoveOrder(order.OrderId);
                Reflash();
            }
           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result= saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }
        //导入
        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                Reflash ();
            }
        }
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0:
                    using (var db = new OrderContext())
                    {
                        bindingSource1.DataSource = db.Orders;
                        //bindingSource1.ResetBindings(false);
                    }
                    break;
                case 1:
                    int.TryParse(QueryText, out int id);
                    bindingSource1.DataSource = orderService.QueryById(id);
                    break;
                case 2:
                    bindingSource1.DataSource = orderService.QueryByCustomerName(QueryText);
                    break;
                case 3:
                    bindingSource1.DataSource = orderService.QueryByGoodsName(QueryText);
                    break;
                case 4:
                    float.TryParse(QueryText, out float totalPrice);
                    bindingSource1.DataSource = orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            bindingSource1.ResetBindings(false);
        }
    }
}
