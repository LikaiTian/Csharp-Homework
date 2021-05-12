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
        BindingSource bdsFields = new BindingSource();
        public Action<AddOrder> ShowAddOrder { get; set; }
        public String Keyword { get; set; }
        public form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            Order order = new Order(1, new Customer("1", "li"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "apple", 100.0), 10));
            order.AddItem(new OrderDetail(2, new Goods("2", "egg", 50.0), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "zhang"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "egg", 200.0), 10));
            orderService.AddOrder(order2);
            txtQuery.DataBindings.Add("Text", this, "Keyword");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrder addOrder = new AddOrder(new Order(), false, orderService);
            addOrder.ShowDialog();
            QueryAll();
        }
        public void QueryAll()
        {
            bindingSource1.DataSource = orderService.Orders;
            bindingSource1.ResetBindings(false);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            EditOrder();

        }
        private void EditOrder()
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            AddOrder form2 = new AddOrder(order, true, orderService);
            form2.ShowDialog();
            QueryAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.OrderId);
            QueryAll();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            DialogResult result= saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0://所有订单
                    bindingSource1.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(Keyword, out int id);
                    Order order = orderService.GetOrder(id);

                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    bindingSource1.DataSource = result;
                    break;
                case 2://根据客户查询
                    bindingSource1.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3://根据货物查询
                    bindingSource1.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                    break;
                case 4://根据总价格查询（大于某个总价）
                    float.TryParse(Keyword, out float totalPrice);
                    bindingSource1.DataSource =
                           orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            bindingSource1.ResetBindings(false);
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            EditOrder();
        }
    }
}
