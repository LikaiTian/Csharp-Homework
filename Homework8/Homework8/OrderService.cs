using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Homework8
{
  public class OrderService {

    private List<Order> orders;


    public OrderService() {
      orders = new List<Order>();
    }

    public List<Order> Orders {
      get => orders;
    }

    public Order QueryById(int Id) {
      return orders.Where(o => o.OrderId == Id).FirstOrDefault();
    }

    public void AddOrder(Order order) {
      if (orders.Contains(order))
        throw new ApplicationException($"订单{order.OrderId} 已经存在了!");
      orders.Add(order);
    }

    public void RemoveOrder(int orderId) {
      Order order = QueryById(orderId);
      if (order != null) {
        orders.Remove(order);
      }
    }

    public List<Order> QueryByGoodsName(string goodsName) {
      var query = orders
              .Where(order => order.Details.Exists (item => item.GoodsName == goodsName))
              .OrderBy(o=>o.TotalPrice);
      return query.ToList();
    }

    public List<Order> QueryByCustomerName(string customerName) {
      return orders
          .Where(order => order.CustomerName == customerName)
          .OrderBy(o => o.TotalPrice)
          .ToList(); 
    }

    public void UpdateOrder(Order order) {
      Order oldOrder = QueryById(order.OrderId);
      if(oldOrder==null)
        throw new ApplicationException($"修改错误：订单 {order.OrderId} 不存在!");
      orders.Remove(oldOrder);
      orders.Add(order);
    }
    public void Export(String fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, Orders);
      }
    }

    public void Import(string fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => {
          if (!orders.Contains(order)) {
            orders.Add(order);
          }
        });
      }
    }

    public object QueryByTotalAmount(float amout) {
      return orders
         .Where(order => order.TotalPrice == amout)
         .OrderByDescending(o => o.TotalPrice)
         .ToList();
    }
  }
}
