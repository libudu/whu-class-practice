using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp {

  /**
   * The service class to manage orders
   * */
  public class OrderService {

    //the order list
    private List<Order> orders;


    public OrderService() {
      orders = new List<Order>();
    }

    public List<Order> Orders {
      get { return orders; }
    }

    public Order GetOrder(uint id) {
      return orders.Where(o => o.OrderId == id).FirstOrDefault();
    }

    public void AddOrder(Order order) {
      if (orders.Contains(order))
        throw new ApplicationException($"Add Order Error: Order with id {order.OrderId} already exists!");
      orders.Add(order);
    }

    public void RemoveOrder(uint orderId) {
      Order order = GetOrder(orderId);
      if (order != null) {
        orders.Remove(order);
      }
    }

    public List<Order> QueryOrdersByGoodsName(string goodsName) {
      var query = orders
              .Where(order => order.Items.Exists (item => item.GoodsName == goodsName))
              .OrderBy(o=>o.TotalPrice);
      return query.ToList();
    }

    public List<Order> QueryOrdersByCustomerName(string customerName) {
      return orders
          .Where(order => order.Customer == customerName)
          .OrderBy(o => o.TotalPrice)
          .ToList(); 
    }

    public void UpdateOrder(Order newOrder) {
      Order oldOrder = GetOrder(newOrder.OrderId);
      if(oldOrder==null)
        throw new ApplicationException($"Update Error：the order with id {newOrder.OrderId} does not exist!");
      orders.Remove(oldOrder);
      orders.Add(newOrder);
    }

    public void Sort() {
      orders.Sort();
    }

    public void Sort(Func<Order, Order, int> func) {
      Orders.Sort((o1,o2)=>func(o1,o2));
    }

    public void Export(String fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, Orders);
      }
    }

    public void Import(string path) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(path, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => {
          if (!orders.Contains(order)) {
            orders.Add(order);
          }
        });
      }
    }


  }
}
