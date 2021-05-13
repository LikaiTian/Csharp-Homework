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
        private bool editModel;
        public Order CurrentOrder { get; set; }
        public AddOrder(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            //添加两个客户
            bindingSource1.Add(new Customer("1", "li"));
            bindingSource1.Add(new Customer("2", "zhang"));
            this.cmbCustomer.DataSource = bindingSource1;
            this.cmbCustomer.DisplayMember = "Name";
            this.orderService = orderService;
            this.editModel = model;

            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            this.CurrentOrder = order;
            bindingSource4.DataSource = CurrentOrder.Details;
            dgvDetails.DataSource = bindingSource4;
            txtOrderID.Enabled = !model;
            if (!model)
            {
                CurrentOrder.Customer = (Customer)bindingSource1.Current;
                txtOrderID.DataBindings.Add("Text", CurrentOrder, "OrderId");
            }

        }
        //添加明细
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormDetailEdit formItemEdit = new FormDetailEdit(new OrderDetail());
            try
            {
                if (formItemEdit.ShowDialog() == DialogResult.OK)
                {
                    uint index = 0;
                    if (CurrentOrder.Details.Count != 0)
                    {
                        index = CurrentOrder.Details.Max(i => i.Index) + 1;
                    }
                    formItemEdit.Detail.Index = index;
                    CurrentOrder.AddItem(formItemEdit.Detail);
                    bindingSource4.ResetBindings(false);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        //保存订单
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.editModel)
                {
                    orderService.UpdateOrder(CurrentOrder);
                }
                else
                {
                    orderService.AddOrder(CurrentOrder);
                }
                this.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
        //修改明细
        private void btnModify_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bindingSource4.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行修改");
                return;
            }
            FormDetailEdit formDetailEdit = new FormDetailEdit(detail);
            if (formDetailEdit.ShowDialog() == DialogResult.OK)
            {
                bindingSource4.ResetBindings(false);
            }
        }

        //删除明细
        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderDetail detail = bindingSource4.Current as OrderDetail;
            if (detail == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            CurrentOrder.RemoveDetail(detail);
            bindingSource4.ResetBindings(false);
        }

    }
}

