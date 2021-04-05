using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework6
{
    public class OrderService
    {
        public List<Order> OrderList = new List<Order>();//订单列表属性

        public void Export(string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xs.Serialize(fs, this.OrderList);
            }
            Console.WriteLine("serialized as xml");
            Console.WriteLine(File.ReadAllText(filePath));
        }
        public void Import(string filePath)
        {
            RemoveAll();
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs=new FileStream(filePath, FileMode.Open))
            {
                OrderList = (List<Order>)xs.Deserialize(fs);
                Console.WriteLine("deserialized from xml");
                foreach(Order o in OrderList)
                {
                    Console.WriteLine(o);
                }
            }
        }


        public void RemoveAll()
        {
            OrderList.Clear();
        }
        //添加订单

        public void AddOrder(Order order)
        {
            if (OrderList.Contains(order))
            {
                throw new ApplicationException("订单已存在!");
            }
            else
            {
                OrderList.Add(order);
            }
        }
        //按照ID查询
        public Order QueryByID(string ID)
        {
            var query = OrderList.Where(s => s.ID == ID)
                .OrderBy(s => s.TotalAmount);
            return query.FirstOrDefault();
        }

        //按照订单金额查询
        public List<Order> QueryByAmount(double totalAmount)
        {
            var query = OrderList.Where(s => s.TotalAmount == totalAmount)
                .OrderBy (s=>s.TotalAmount);
                
            List<Order> list = query.ToList();
            return list;
        }

        //按照客户name进行查询
        public List<Order> QueryByCustomer(string customerName)
        {
            var query = OrderList.Where(s => s.Customer.Name.Equals(customerName))
                .OrderBy(s => s.TotalAmount);
            List<Order> list = query.ToList();
            return list;

        }
        //按照商品名字查询
        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = OrderList.Where(s => s.List.Any(m => m.GoodsName.Equals(goodsName)))
                .OrderBy(s => s.TotalAmount);
            List<Order> list = query.ToList();
            return list;
        }
        //删除某个订单
        public void DeleteOrder(string orderID)
        {
            OrderList.RemoveAll(o => o.ID == orderID);
        }

        //修改订单
        public void UpdateOrder(Order order)
        {
            DeleteOrder(order.ID);
            OrderList.Add(order);
        }

    }
}
