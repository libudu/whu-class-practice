using Microsoft.VisualStudio.TestTools.UnitTesting;
using practice5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService os = new OrderService();

        [TestMethod()]
        public void CreateOrderTest()
        {
            var order = os.CreateOrder("test order");
            Assert.AreEqual(order.OrderName, "test order");
        }

        [TestMethod()]
        public void ExportXMLTest()
        {
            os.ExportXML("s.xml");
            var read_os = new OrderService();
            read_os.ImportXML("s.xml");
            Assert.AreEqual(os.orderlist.Count(), read_os.orderlist.Count());
            for(int i = 0; i < os.orderlist.Count(); i++)
            {
                Assert.AreEqual(os.orderlist[i].OrderName, read_os.orderlist[i].OrderName);
            }
        }

        [TestMethod()]
        public void ImportXMLTest()
        {
            Assert.Fail();
        }
    }
}