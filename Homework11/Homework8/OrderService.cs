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


    public OrderService() {
      //orders = new List<Order>();
    }

    /*public List<Order> Orders {
      get => orders;
    }*/

    public IEnumerable<Order> QueryById(int Id) {

      //return orders.Where(o => o.OrderId == Id).FirstOrDefault();
      using(var db=new OrderContext())
            {
                return from o in db.Orders.Include(o => o.OrderId==Id)
                       orderby o.TotalPrice
                       select o;
                //var order = db.Orders.Include("details").FirstOrDefault(p => p.OrderId == Id);
            }
    }

    public void AddOrder(Order order) {

   
      /*if (orders.Contains(order))
        throw new ApplicationException($"订单{order.OrderId} 已经存在了!");
      orders.Add(order);*/

        using(var db=new OrderContext())
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
                    order.CreateTime = DateTime.Now;
                    db.Orders.Add(order);
                    //db.Entry(order).State = EntityState.Added;
                    db.SaveChanges();
                }
                
            }
    }

    public void RemoveOrder(int orderId) {
            using (var db = new OrderContext())
            {
                var order = db.Orders.Include("details").FirstOrDefault(p => p.OrderId == orderId);
                if (order != null) {
                    db.Orders.Remove(order);
                    db.SaveChanges();
                    //orders.Remove(order);
                }
            }
                
      
    }

    public List<Order> QueryByGoodsName(string goodsName) {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("details")
                    .Where(order => order.Details.Exists(item => item.GoodsName == goodsName))
                    .OrderBy(o => o.TotalPrice);
                return query.ToList();
            }
    }

    public List<Order> QueryByCustomerName(string customerName) {
            using (var db = new OrderContext())
            {
                var query = db.Orders.Include("details")
                    .Where(order => order.CustomerName == customerName)
                    .OrderBy(o => o.TotalPrice);
                return query.ToList();
            }

    }

    public void UpdateOrder(Order order) {
            using (var db = new OrderContext())
            {
                var oldOrder = db.Orders.Include("details").FirstOrDefault(p => p.OrderId == order.OrderId);
                if (oldOrder == null)
                    throw new ApplicationException($"修改错误：订单 {order.OrderId} 不存在!");
                db.Orders.Remove(oldOrder);
                order.CreateTime = DateTime.Now;
                db.Orders.Add(order);
                db.SaveChanges();
            }
                //Order oldOrder = QueryById(order.OrderId);

     /* if(oldOrder==null)
        throw new ApplicationException($"修改错误：订单 {order.OrderId} 不存在!");
      orders.Remove(oldOrder);
      orders.Add(order);*/
    }
    public void Export(String fileName) {
            using (var db = new OrderContext())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    xs.Serialize(fs, db.Orders);
                }
            }
                /*XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, Orders);
      }*/
    }

    public void Import(string fileName) {
            using (var db = new OrderContext())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order => {
                        if (!db.Orders.Contains(order))
                        {
                            db.Orders.Add(order);
                        }
                    });
                }
                db.SaveChanges();
            }
                /*XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => {
          if (!orders.Contains(order)) {
            orders.Add(order);
          }
        });
      }*/
    }

    public object QueryByTotalAmount(float amout) {
            using (var db = new OrderContext())
            {
                return db.Orders
                    .Where(order => order.TotalPrice == amout)
                    .OrderByDescending(o => o.TotalPrice)
                    .ToList();
            }
                /*return orders
         .Where(order => order.TotalPrice == amout)
         .OrderByDescending(o => o.TotalPrice)
         .ToList();*/
    }
  }
}
