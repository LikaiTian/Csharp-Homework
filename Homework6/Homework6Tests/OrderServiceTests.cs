using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();
        public void Initial()
        {
            Customer customer1 = new Customer("Customer1", 18, "男");
            Customer customer2 = new Customer("Customer2", 20, "女");

            OrderDetails milk = new OrderDetails("Milk", 30, 1);
            OrderDetails eggs = new OrderDetails("eggs", 2.5, 2);
            OrderDetails apple = new OrderDetails("apple", 3.9, 3);

            Order order1 = new Order("U100001", customer1, DateTime.Now, "武汉市");
            order1.AddDetails(milk);
            order1.AddDetails(eggs);
            for (int i = 0; i < order1.List.Count; i++)
            {
                order1.TotalAmount += order1.List[i].Amount * order1.List[i].Price;
            }

            Order order2 = new Order("U100002", customer1, DateTime.Now, "北京市");
            order2.AddDetails(apple);
            order2.AddDetails(eggs);
            for (int i = 0; i < order2.List.Count; i++)
            {
                order2.TotalAmount += order2.List[i].Amount * order2.List[i].Price;
            }

            Order order3 = new Order("U100003", customer2, DateTime.Now, "南京市");
            order3.AddDetails(milk);
            for (int i = 0; i < order3.List.Count; i++)
            {
                order3.TotalAmount += order3.List[i].Amount * order3.List[i].Price;
            }
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }
        [TestMethod()]
        public void ExportTest()
        {
            Initial();
            orderService.Export("test.xml");
            Assert.IsTrue(File.Exists("test.xml"));
            
        }

        [TestMethod()]
        public void ImportTest()
        {
            Initial();
            orderService.Import("test.xml");
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Initial();
        }

        [TestMethod()]
        public void QueryByIDTest()
        {
            Initial();
            Order o = orderService.QueryByID("U100003");
            Assert.IsNotNull(o);
            Assert.AreEqual(o, orderService.OrderList[2]);
            Assert.IsNull(orderService.QueryByID("U100004"));
        }

        [TestMethod()]
        public void QueryByAmountTest()
        {
            Initial();
            List<Order> o = orderService.QueryByAmount(35);
            Assert.IsNotNull(o);
            foreach(Order m in o)
            {
                Assert.IsTrue(m.TotalAmount==35);
            }
        }

        [TestMethod()]
        public void QueryByCustomerTest()
        {
            Initial();
            List<Order> o = orderService.QueryByCustomer("customer1");
            Assert.IsNotNull(o);
            foreach (Order m in o)
            {
                Assert.IsTrue(m.Customer.Name=="customer1");
            }
        }

        [TestMethod()]
        public void QueryByGoodsNameTest()
        {
            Initial();
            List<Order> o = orderService.QueryByGoodsName("apple");
            Assert.IsNotNull(o);
            foreach (Order m in o)
            {
                var query = m.List.Where(s => s.GoodsName == "apple");
                Assert.IsNotNull(query);
            }
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            Initial();
            orderService.DeleteOrder("U100001");
            Assert.IsNull(orderService.QueryByID("U100001"));
        }

        [TestMethod()]
        public void UpdateOrderTest()
        {
            Initial();
            orderService.DeleteOrder("U100001");
            Assert.IsNull(orderService.QueryByID("U100001"));
            Customer customer1 = new Customer("Customer1", 18, "男");
            Order order1 = new Order("U100001", customer1, DateTime.Now, "武汉市");
            OrderDetails milk = new OrderDetails("Milk", 30, 1);
            order1.AddDetails(milk);
            orderService.AddOrder(order1);
            Assert.IsNotNull(orderService.QueryByID("U100001"));
        }
    }
}