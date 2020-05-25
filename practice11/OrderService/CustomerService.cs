using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {
  public class CustomerService {

    public static void Add(Customer customer) {
      try {
        using (var db = new OrderContext()) {
          db.Customers.Add(customer);
          db.SaveChanges();
        }
      }
      catch (Exception e) {
        //TODO 需要更加错误类型返回不同错误信息
        throw new ApplicationException($"添加错误!");
      }
    }

    public static List<Customer> GetAll() {
      using (var db = new OrderContext()) {
        return db.Customers.ToList();
      }
    }
  }

}
