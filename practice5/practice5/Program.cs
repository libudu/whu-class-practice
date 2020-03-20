using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager manager = new OrderManager();
            manager.Welcome();
            while (manager.Running)
            {
                manager.OrderOperation();
            }
        }
    }

    // 订单项
    // 包含一个订单项的名字、数量、价格、折扣、总价
    class OrderItem
    {
        public string ItemName { get; set; }
        public int ItemNum { get; set; }
        public double ItemPrice { get; set; }
        public double ItemDiscount { get; set; }
        public double ItemTotalPrice { get { return ItemNum * ItemPrice * ItemDiscount; } }

        // 构造函数，默认不打折
        public OrderItem(string ItemName, int ItemNum, double ItemPrice)
        {
            this.ItemName = ItemName;
            this.ItemNum = ItemNum;
            this.ItemPrice = ItemPrice;
            this.ItemDiscount = 1.0;
        }

        // 构造函数，指定打折数
        public OrderItem(string ItemName, int ItemNum, double ItemPrice, double ItemDiscount) : this(ItemName, ItemNum, ItemPrice)
        {
            this.ItemDiscount = ItemDiscount;
        }
    }

    //  订单类
    class Order
    {
        // 订单名
        public string OrderName;
        // 订单号
        public int OrderId { get { return GetHashCode(); } }

        // 【私有】内部的OrderItem列表
        private List<OrderItem> OrderItemList = new List<OrderItem>();

        // 【构造】默认订单名称
        public Order()
        {
            OrderName = "默认订单";
        }

        // 【构造】指定订单名称
        public Order(string OrderName)
        {
            this.OrderName = OrderName;
        }

        // 添加一个OrderItem
        public bool AddOrderItem(string ItemName, int ItemNum, double ItemPrice, double ItemDiscount = 1.0)
        {
            OrderItem item = new OrderItem(ItemName, ItemNum, ItemPrice, ItemDiscount);
            OrderItemList.Add(item);
            return true;
        }

        // 通过索引删除OrderItem
        public bool DeleteOrderItemByIndex(int index)
        {
            if(index < 0 || index > OrderItemList.Count())
                return false;
            OrderItemList.RemoveAt(index);
            return true;
        }

        // 修改一个OrderItem
        public void ModifyOrderItem()
        {

        }

        // 获取OrderItem总数
        public int GetOrderItemCount()
        {
            return OrderItemList.Count();
        }
    }
    
    // 订单服务，用来管理订单
    // 提供LINQ操作
    class OrderService
    {
        // 【私有】内部的订单列表
        private List<Order> orderlist = new List<Order>();
        public List<Order> OrderList { get { return orderlist; } }

        // 创建一个订单
        public void CreateOrder(string OrderName)
        {
            OrderList.Add(new Order(OrderName));
        }

    }

    // 订单管理系统，提供命令行交互提示
    class OrderManager
    {
        public bool Running = true;

        // 持有一个OrderService
        private OrderService service = new OrderService();

        // 欢迎语句
        public void Welcome()
        {
            Write("~~~~~欢迎来到订单管理系统~~~~~~~");
        }

        // 操作提示语句
        public void InputTip()
        {
            Write("===================================================");
            Write("按c创建一个订单，按s查看所有订单，按d删除一个订单。");
        }

        // 获取用户输入
        private char GetInput()
        {
            InputTip();
            Write("请输入操作命令：");
            return Console.ReadKey().KeyChar;
        }

        // 对订单进行操作
        public void OrderOperation()
        {
            char operation = GetInput();
            switch (operation)
            {
                case 'c':
                    CreateOrder();
                    break;
                case 's':
                    ShowAllOrder();
                    break;
                case 'd':
                    DeleteOrder();
                    break;
                default:
                    Write("输入错误，请重新输入！");
                    break;
            }
        }

        // 添加一个订单
        public void CreateOrder()
        {
            Write("创建订单！请输入订单名称");
            string OrderName = Console.ReadLine();
            service.CreateOrder(OrderName);
        }
        
        // 查看所有订单
        public void ShowAllOrder()
        {
            Write("显示所有订单");
            ShowOrderList(service.OrderList);
        }

        // 显示一个订单列表中所有订单
        public void ShowOrderList(List<Order> OrderList)
        {
            foreach(Order order in OrderList)
            {
                ShowOrder(order);
            }
        }

        // 显示一个订单
        private void ShowOrder(Order order)
        {
            Write("订单名称：" + order.OrderName);
        }

        // 删除一个订单
        private void DeleteOrder()
        {
            Write("删除订单！");
            Write("请输入要删除的订单号，输入-1返回上一步：");
            // 进一步细化
        }

        
        // 【内部辅助函数】简化操作
        private void Write(string text)
        {
            Console.WriteLine(text);
        }
    }

}
