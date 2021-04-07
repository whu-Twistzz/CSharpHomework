using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework06_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace homework06_1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void addOrderTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            os.addOrder();
            List<Order> list = new List<Order>() { o1, o2 };
            Assert.AreEqual(list, os.orders);
        }

        [TestMethod()]
        public void removeOrderTest1()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            os.orders.Add(o1);
            os.orders.Add(o2);
            List<Order> list = new List<Order>() { o1 };
            os.removeOrder();
            Assert.AreEqual(list, os.orders);

        }

        [TestMethod()]
        public void removeOrderTest2()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            os.orders.Add(o1);
            os.orders.Add(o2);
            List<Order> list = new List<Order>() { o1, o2 };
            list[1].removeOrderDetails();
            os.removeOrder();
            Assert.AreEqual(list, os.orders);
        }

        [TestMethod()]
        public void searchOrderTest1()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            Order o3 = new Order(125, "小刚", 0);
            Order o4 = new Order(126, "小刚", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            o2.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o3.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o4.orderDetails.Add(new OrderDetails("商品3", 2, 50));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.orders.Add(o3);
            os.orders.Add(o4);
            List<Order> queryList = os.SearchOrder();
            List<Order> list = new List<Order>() { o1 };
            Assert.AreEqual(list, queryList);
        }

        [TestMethod()]
        public void searchOrderTest2()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            Order o3 = new Order(125, "小刚", 0);
            Order o4 = new Order(126, "小刚", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            o2.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o3.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o4.orderDetails.Add(new OrderDetails("商品3", 2, 50));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.orders.Add(o3);
            os.orders.Add(o4);
            List<Order> queryList = os.SearchOrder();
            List<Order> list = new List<Order>() { o2, o3, o4 };
            Assert.AreEqual(list, queryList);
        }

        [TestMethod()]
        public void searchOrderTest3()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            Order o3 = new Order(125, "小刚", 0);
            Order o4 = new Order(126, "小刚", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            o2.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o3.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o4.orderDetails.Add(new OrderDetails("商品3", 2, 50));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.orders.Add(o3);
            os.orders.Add(o4);
            List<Order> queryList = os.SearchOrder();
            List<Order> list = new List<Order>() { o3, o4 };
            Assert.AreEqual(list, queryList);
        }

        [TestMethod()]
        public void searchOrderTest4()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            Order o3 = new Order(125, "小刚", 0);
            Order o4 = new Order(126, "小刚", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            o2.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o3.orderDetails.Add(new OrderDetails("商品3", 1, 50));
            o4.orderDetails.Add(new OrderDetails("商品3", 2, 50));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.orders.Add(o3);
            os.orders.Add(o4);
            List<Order> queryList = os.SearchOrder();
            List<Order> list = new List<Order>() { o1, o4 };
            Assert.AreEqual(list, queryList);
        }

        [TestMethod()]
        public void sortOrdersTest1()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(124, "小明", 0);
            Order o2 = new Order(123, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.sortOrders();
            List<Order> list = new List<Order>() { o2, o1 };
            Assert.AreEqual(list, os.orders);
        }

        [TestMethod()]
        public void sortOrdersTest2()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 1, 75));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.sortOrders((o11, o22) => o1.getMoney() - o2.getMoney());
            List<Order> list = new List<Order>() { o2, o1 };
            Assert.AreEqual(list, os.orders);
        }

        [TestMethod()]
        public void exportTest()
        {
            OrderService os = new OrderService();
            Order o1 = new Order(123, "小明", 0);
            Order o2 = new Order(124, "小红", 0);
            o1.orderDetails.Add(new OrderDetails("商品1", 1, 100));
            o2.orderDetails.Add(new OrderDetails("商品2", 2, 75));
            os.orders.Add(o1);
            os.orders.Add(o2);
            os.export();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            Order[] orders;
            using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
            {
                orders = (Order[])xmlSerializer.Deserialize(fs);
            }
            Assert.AreEqual(os.orders, orders.ToList());
        }

        [TestMethod()]
        public void importTest()
        {
            OrderService os = new OrderService();
            os.import();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            Order[] orders;
            using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
            {
                orders = (Order[])xmlSerializer.Deserialize(fs);
            }
            CollectionAssert.Equals(os.orders.ToArray(), orders);
        }

        
    }
}