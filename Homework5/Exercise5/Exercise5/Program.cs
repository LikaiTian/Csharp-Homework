using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            bool tag = true;
            while (tag)
            {
                Console.WriteLine("请选择要进行的业务：1.添加订单\t2.删除订单\t3.修改订单\t4.查询订单");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1: orderService.AddOrder();break;
                    case 2: 
                        Console.WriteLine("请选择查询方式：1.按照ID查询\t2.按照订单金额查询\t3.按照客户进行查询");
                        switch (Convert.ToInt32(Console.ReadLine())) {
                            case 1:
                                Console.WriteLine("输入要查询的ID号");
                                List<Order> order1 = orderService.Query(Console.ReadLine());
                                for(int i = 0; i < order1.Count; i++)
                                {
                                    orderService.DeleteOrder(order1[i]);
                                }
                                break;
                            case 2:
                                Console.WriteLine("输入要查询的订单金额");
                                List<Order> order2 = orderService.Query(Convert.ToDouble(Console.ReadLine()));
                                for (int i = 0; i < order2.Count; i++)
                                {
                                    orderService.DeleteOrder(order2[i]);
                                }
                                break;
                            case 3:
                                Console.WriteLine("输入要查询的客户信息（name age sex）");
                                string line = Console.ReadLine();
                                string[] messages = line.Split(' ');
                                Customer customer = new Customer(messages[0], Int32.Parse(messages[1]), messages[2]);
                                List<Order> order3 = orderService.Query(customer);
                                for (int i = 0; i < order3.Count; i++)
                                {
                                    orderService.DeleteOrder(order3[i]);
                                }
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("请选择查询方式：1.按照ID查询\t2.按照订单金额查询\t3.按照客户进行查询");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("输入要查询的ID号");
                                List<Order> order1 = orderService.Query(Console.ReadLine());
                                for (int i = 0; i < order1.Count; i++)
                                {
                                    orderService.ChangeOrder(order1[i]);
                                }
                                break;
                            case 2:
                                Console.WriteLine("输入要查询的订单金额");
                                List<Order> order2 = orderService.Query(Convert.ToDouble(Console.ReadLine()));
                                for (int i = 0; i < order2.Count; i++)
                                {
                                    orderService.ChangeOrder(order2[i]);
                                }
                                break;
                            case 3:
                                Console.WriteLine("输入要查询的客户信息（name age sex）");
                                string line = Console.ReadLine();
                                string[] messages = line.Split(' ');
                                Customer customer = new Customer(messages[0], Int32.Parse(messages[1]), messages[2]);
                                List<Order> order3 = orderService.Query(customer);
                                for (int i = 0; i < order3.Count; i++)
                                {
                                    orderService.ChangeOrder(order3[i]);
                                }
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("请选择查询方式：1.按照ID查询\t2.按照订单金额查询\t3.按照客户进行查询");
                        switch (Convert.ToInt32(Console.ReadLine()))
                        {
                            case 1:
                                Console.WriteLine("输入要查询的ID号");
                                List<Order> order1 = orderService.Query(Console.ReadLine());
                                foreach(Order o in order1)
                                {
                                    Console.WriteLine(o.ToString());
                                }
                                break;
                            case 2:
                                Console.WriteLine("输入要查询的订单金额");
                                List<Order> order2 = orderService.Query(Convert.ToDouble(Console.ReadLine()));
                                foreach (Order o in order2)
                                {
                                    Console.WriteLine(o.ToString());
                                }
                                break;
                            case 3:
                                Console.WriteLine("输入要查询的客户信息（name age sex）");
                                string line = Console.ReadLine();
                                string[] messages = line.Split(' ');
                                Customer customer = new Customer(messages[0], Int32.Parse(messages[1]), messages[2]);
                                List<Order> order3 = orderService.Query(customer);
                                foreach (Order o in order3)
                                {
                                    Console.WriteLine(o.ToString());
                                }
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("输入错误，请再次选择！");
                        break;
                }

                Console.WriteLine("是否继续进行业务处理(Y/N)");
                if (Console.ReadLine() == "N")
                {
                    tag = false;
                }
            }
        }
    }
}
