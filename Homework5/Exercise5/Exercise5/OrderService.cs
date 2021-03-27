using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class OrderService
    {
        public List<Order> OrderList = new List<Order>();//订单列表属性

        //添加订单
        public void AddOrder()
        {
            Order order = new Order();
            Console.WriteLine("请问是否开始添加订单（Y/N）");
            switch (Console.ReadLine())
            {
                case "Y":
                    bool flag = true;//是否继续追加订单明细的标志
                    while (flag)
                    {
                        Console.WriteLine("请问是否继续添加商品（Y/N）");
                        string tag = Console.ReadLine();
                        switch (tag)
                        {
                            case "Y":
                                //构建一个商品明细
                                Console.WriteLine("请输入商品名称");

                                string goodsName = Console.ReadLine();

                                Console.WriteLine("请输入商品价格");

                                double price = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("请输入要购买的该商品的数量");

                                int amount = Convert.ToInt32(Console.ReadLine());

                                OrderDetails goods1 = new OrderDetails(goodsName, price, amount);
                                order.List.Add(goods1);
                                break;
                            case "N":
                                flag = false;
                                Console.WriteLine("商品添加完成");
                                break;
                        }

                    }

                    Console.WriteLine("请输入收货人信息（name age sex）:");
                    string line = Console.ReadLine();
                    string[] messages = line.Split(' ');
                    order.Customer.Name = messages[0];
                    order.Customer.Age = Int32.Parse(messages[1]);
                    order.Customer.Sex = messages[2];

                    Console.WriteLine("请输入收货地址：");
                    order.Address = Console.ReadLine();

                    //下单时间
                    order.OrderTime = DateTime.Now;
                    //生成单号ID
                    order.ID = DateTime.Now.Ticks.ToString();
                    //计算总金额
                    foreach (OrderDetails o in order.List)
                    {
                        order.TotalAmount += o.Price * o.Amount;
                    }

                    OrderList.Add(order);
                    //按照订单编号排序
                    OrderList.Sort((a, b) => (int)(long.Parse(a.ID) - long.Parse(b.ID)));
                    break;
                case "N":
                    break;
            }
            
        }

        //按照ID查询
        public List<Order> Query(string ID)
        {
            var query = OrderList.Where(s => s.ID == ID)
                .OrderBy(s => s.TotalAmount);
            List<Order> list = query.ToList();
            return list;
        }

        //按照订单金额查询
        public List<Order> Query(double totalAmount)
        {
            var query = OrderList.Where(s => s.TotalAmount == totalAmount)
                .OrderBy (s=>s.TotalAmount);
                
            List<Order> list = query.ToList();
            return list;
        }

        //按照客户进行查询
        public List<Order> Query(Customer customer)
        {
            var query = OrderList.Where(s => s.Customer.Equals(customer))
                .OrderBy(s => s.TotalAmount);
            List<Order> list = query.ToList();
            return list;

        }

        //删除某个订单
        public void DeleteOrder(Order order)
        {
            try
            {
                OrderList.Remove(order);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message+"!!!该订单不存在");
            }
        }

        //修改订单
        public void ChangeOrder(Order order)
        {
            try
            {
                Console.WriteLine("请问要修改什么订单信息？");
                Console.WriteLine("1:Customer\t2:Address\t3:List");
                int tag = Convert.ToInt32(Console.ReadLine());

                switch (tag)
                {

                    case 1:
                        Console.WriteLine("请输入更新后的收货人信息（name age sex）:");
                        string line = Console.ReadLine();
                        string[] messages = line.Split(' ');
                        order.Customer.Name = messages[0];
                        order.Customer.Age = Int32.Parse(messages[1]);
                        order.Customer.Sex = messages[2];
                        break;

                    case 2:
                        Console.WriteLine("请输入修改后的收货地址：");
                        order.Address = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("请输入要修改的商品的名称：");
                        string goods = Console.ReadLine();

                        for (int i = 0; i < order.List.Count; i++)
                        {
                            if (order.List[i].GoodsName == goods)
                            {

                                Console.WriteLine("请修改购买的该商品数量为:(0~n)");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                if (amount == 0)
                                {
                                    order.List.RemoveAt(i);
                                    order.ID = DateTime.Now.Ticks.ToString();
                                    //下单时间
                                    order.OrderTime = DateTime.Now;
                                    //计算总金额
                                    foreach (OrderDetails o in order.List)
                                    {
                                        order.TotalAmount += o.Price * o.Amount;
                                    }
                                    break;
                                }
                                else
                                {
                                    order.List[i].Amount = amount;
                                    order.ID = DateTime.Now.Ticks.ToString();
                                    //下单时间
                                    order.OrderTime = DateTime.Now;
                                    //计算总金额
                                    order.TotalAmount = 0;
                                    foreach (OrderDetails o in order.List)
                                    {

                                        order.TotalAmount += o.Price * o.Amount;
                                    }
                                    break;
                                }

                            }
                        }
                        break;
                    default: break;

                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }

    }
}
