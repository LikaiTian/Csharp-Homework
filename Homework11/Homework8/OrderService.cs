using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Homework8
{
  public class OrderService {

    //private List<Order> orders;


        public OrderService() { }
        public List<Order> Orders
        {
            get
            {
                using (var db = new OrderContext())
                {
                    return db.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer").
                      ToList<Order>();
                }
            }
        }

        public Order QueryById(int Id) {

            using(var db=new OrderContext())
            {
                return db.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                    .FirstOrDefault(o => o.OrderId == Id);
            }
        }
        public void AddOrder(Order order) {

            using (var db=new OrderContext())
            {
                
                    if (order == null && order.Details == null)
                {
                    throw new ApplicationException("参数不能为空!");
                }
                else if (db.Orders.Where(o => o.OrderId == order.OrderId).Any())
                {
                    throw new ApplicationException($"订单{order.OrderId} 已经存在了!");
                }
                else
                {
                    db.Entry(order).State = EntityState.Added;
                    db.SaveChanges();
                }
                
            }
        }

        public void RemoveOrder(int orderId) {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("Details").SingleOrDefault(p => p.OrderId == orderId);
                if (order != null) {
                    db.OrderDetails.RemoveRange(order.Details);
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
            }
                
      
        }

        public List<Order> QueryByGoodsName(string goodsName) {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                    .Where(o => o.Details.Any(m => m.GoodsItem.Name == goodsName));
                return query.ToList();
            }
        }

        public List<Order> QueryByCustomerName(string customerName) {
            using (var db = new OrderContext())
            {
                return db.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                    .Where(order => order.Customer.Name == customerName).ToList();
                //.OrderBy(o => o.TotalPrice)
            }

        }
        public object QueryByTotalAmount(float amout)
        {
            using (var db = new OrderContext())
            {
                return db.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer")
                .Where(order => order.Details.Sum(d => d.Quantity * d.GoodsItem.Price) > amout)
                .ToList();
            }
        }

        public void UpdateOrder(Order order) {
            RemoveOrder(order.OrderId);
            AddOrder(order);
        }
        public void Export(String fileName) {
            using (var db = new OrderContext())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    xs.Serialize(fs, Orders);
                }
            }
                
        }

        public void Import(string fileName) {
            using (var db = new OrderContext())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order => {
                        if (db.Orders.SingleOrDefault(o => o.OrderId == order.OrderId) == null)
                        {
                            //FixOrder(order);
                            db.Orders.Add(order);
                        }
                    });
                }
                db.SaveChanges();
            }
                
        }

    
  }
}
