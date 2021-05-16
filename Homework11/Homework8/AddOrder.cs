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
    public partial class AddOrder : Form
    {
        
        private OrderService orderService;
        private bool flag;
        public Order CurrentOrder { get; set; }
        public AddOrder(Order order, bool flag, OrderService orderService)
        {
            InitializeComponent();
            //添加三个客户
            bindingSource1.Add(new Customer("1", "小明"));
            bindingSource1.Add(new Customer("2", "小王"));
            bindingSource1.Add(new Customer("2", "小张"));
            //客户选择的数据绑定
            this.cmbCustomer.DataSource = bindingSource1;
            this.cmbCustomer.DisplayMember = "Name";
            //初始化
            this.orderService = orderService;
            this.flag = flag;
            this.CurrentOrder = order;
            //dgv数据绑定
            bindingSource4.DataSource = CurrentOrder.Details;
            dgvDetails.DataSource = bindingSource4;

            CurrentOrder.Customer = (Customer)bindingSource1.Current;
            txtOrderID.DataBindings.Add("Text", CurrentOrder, "OrderId");

        }
        //添加明细
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoodEdit goodEdit = new GoodEdit(CurrentOrder, new OrderDetail(), true);
            goodEdit.ShowDialog();
            bindingSource4.ResetBindings(false);
        }
        //保存订单
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                orderService.AddOrder(CurrentOrder);
            }
            else
            {
                orderService.UpdateOrder(CurrentOrder);
            }
            this.Close();
        }
        //修改明细
        private void btnModify_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bindingSource4.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单明细修改");
            }
            else
            {
                GoodEdit goodEdit = new GoodEdit(CurrentOrder, detail, false);
                goodEdit.ShowDialog();
                bindingSource4.ResetBindings(false);
            }
            
        }
        //删除明细
        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bindingSource4.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单明细删除");
            }
            else
            {
                CurrentOrder.RemoveDetail(detail);
                bindingSource4.ResetBindings(false);
            }
            
        }
    }
}

