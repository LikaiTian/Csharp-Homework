using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new Customer("Customer1", 18, "男");
                Customer customer2 = new Customer("Customer2", 20, "女");

                OrderDetails milk = new OrderDetails("Milk", 30, 1);
                OrderDetails eggs = new OrderDetails("eggs", 2.5, 2);
                OrderDetails apple = new OrderDetails("apple", 3.9, 3);

                Order order1 = new Order("U100001", customer1, DateTime.Now, "武汉市");
                order1.AddDetails(milk);
                order1.AddDetails(eggs);
                for(int i=0;i< order1.List.Count; i++)
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

                OrderService orderService = new OrderService();
                orderService.AddOrder(order1);
                orderService.AddOrder(order2);
                orderService.AddOrder(order3);

                orderService.Export("Order.xml");
                orderService.Import("Order.xml");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
