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
        public String Keyword { get; set; }
        public form1()
        {
            InitializeComponent();
            orderService = new OrderService();
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
            //更新一下信息
            bindingSource1.DataSource = orderService.Orders;
            bindingSource1.ResetBindings(false);
        }
        //编辑选中的订单
        private void btnModify_Click(object sender, EventArgs e)
        {
            Edit();

        }
        private void Edit()
        {
            Order order = bindingSource1.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            AddOrder form = new AddOrder(order, true, orderService);
            form.ShowDialog();
            QueryAll();
        }
        //删除选中的订单
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
                QueryAll();
            }
        }
        //查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            switch (cmbQuery.SelectedIndex)
            {
                case 0://所有订单
                    bindingSource1.DataSource = orderService.Orders;
                    break;
                case 1://根据ID查询
                    int.TryParse(Keyword, out int id);
                    bindingSource1.DataSource = orderService.GetOrder(id);
                    break;
                case 2://根据客户查询
                    bindingSource1.DataSource = orderService.QueryOrdersByCustomerName(Keyword);
                    break;
                case 3://根据货物查询
                    bindingSource1.DataSource = orderService.QueryOrdersByGoodsName(Keyword);
                    break;
                case 4://根据总价格查询（大于某个总价）
                    float.TryParse(Keyword, out float totalPrice);
                    bindingSource1.DataSource = orderService.QueryByTotalAmount(totalPrice);
                    break;
            }
            bindingSource1.ResetBindings(false);
        }
    }
}
