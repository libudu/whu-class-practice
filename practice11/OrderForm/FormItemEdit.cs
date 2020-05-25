using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderForm {
  public partial class FormItemEdit : Form {
    public OrderItem OrderItem { get; set; }

    public FormItemEdit() {
      InitializeComponent();
    }

    public FormItemEdit(OrderItem orderItem):this() {
      this.OrderItem = orderItem;
      this.ItemBindingSource.DataSource = orderItem;
      List<Goods> goods = GoodsService.GetAll();
      if (goods.Count == 0) {
        GoodsService.Add(new Goods("apple", 100.0));
        GoodsService.Add(new Goods("egg", 200.0));
        goods= GoodsService.GetAll();
      }
      goodsBindingSource.DataSource = goods;
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      ItemBindingSource.ResetBindings(false);
    }
  }
}
