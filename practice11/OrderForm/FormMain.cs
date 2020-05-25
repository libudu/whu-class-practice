
using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm {
  public partial class FormMain : Form {
    BindingSource fieldsBS = new BindingSource();
    public String Keyword { get; set; }

    public FormMain() {
      InitializeComponent();
      //Order order = new Order(1, new Customer("1", "li"), new List<OrderItem>());
      //order.AddItem(new OrderItem(1, new Goods("1", "apple", 100.0), 10));
      //order.AddItem(new OrderItem(1, new Goods("2", "egg", 50.0), 61));
      //orderService.AddOrder(order);
      //Order order2 = new Order(2, new Customer("2", "zhang"), new List<OrderItem>());
      //order2.AddItem(new OrderItem(1, new Goods("2", "egg", 200.0), 10));
      //orderService.AddOrder(order2);
      orderBindingSource.DataSource = OrderService.GetAllOrders();
      cbField.SelectedIndex = 0;
      txtValue.DataBindings.Add("Text", this, "Keyword");
    }

    private void btnAdd_Click(object sender, EventArgs e) {
      FormEdit form2 = new FormEdit(new Order());
      if (form2.ShowDialog() == DialogResult.OK) {
        OrderService.AddOrder(form2.CurrentOrder);
        QueryAll();
      }
    }

    private void QueryAll() {
      orderBindingSource.DataSource = OrderService.GetAllOrders();
      orderBindingSource.ResetBindings(false);
    }

    private void btnModify_Click(object sender, EventArgs e) {
      EditOrder();
    }
    private void dbvOrders_DoubleClick(object sender, EventArgs e) {
      EditOrder();
    }
    private void EditOrder() {
      Order order = orderBindingSource.Current as Order;
      if (order == null) {
        MessageBox.Show("请选择一个订单进行修改");
        return;
      }
      order = OrderService.GetOrder(order.Id); //查询出最新的订单信息
      FormEdit form2 = new FormEdit(order, true);
      if (form2.ShowDialog() == DialogResult.OK) {
        OrderService.UpdateOrder(form2.CurrentOrder);
        QueryAll();
      }
    }

    private void btnDelete_Click(object sender, EventArgs e) {
      Order order = orderBindingSource.Current as Order;
      if (order == null) {
        MessageBox.Show("请选择一个订单进行删除");
        return;
      }
      OrderService.RemoveOrder(order.Id);
      QueryAll();
    }

    private void btnExport_Click(object sender, EventArgs e) {
      DialogResult result = saveFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = saveFileDialog1.FileName;
        OrderService.Export(fileName);
      }
    }

    private void btnImport_Click(object sender, EventArgs e) {
      DialogResult result = openFileDialog1.ShowDialog();
      if (result.Equals(DialogResult.OK)) {
        String fileName = openFileDialog1.FileName;
        OrderService.Import(fileName);
        QueryAll();
      }
    }

    private void btnQuery_Click(object sender, EventArgs e) {
      switch (cbField.SelectedIndex) {
        case 0://所有订单
          orderBindingSource.DataSource = OrderService.GetAllOrders();
          break;
        case 1://根据ID查询
          Order order = OrderService.GetOrder(Keyword);
          List<Order> result = new List<Order>();
          if (order != null) result.Add(order);
          orderBindingSource.DataSource = result;
          break;
        case 2://根据客户查询
          orderBindingSource.DataSource = OrderService.QueryOrdersByCustomerName(Keyword);
          break;
        case 3://根据货物查询
          orderBindingSource.DataSource = OrderService.QueryOrdersByGoodsName(Keyword);
          break;
        case 4://根据总价格查询（大于某个总价）
          float.TryParse(Keyword,  out float totalPrice);
          orderBindingSource.DataSource =
                 OrderService.QueryByTotalAmount(totalPrice);
          break;
      }
      orderBindingSource.ResetBindings(true);

    }

 
  }
}
