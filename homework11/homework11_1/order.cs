using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework08_1
{
    //订单类
    public class Order : IComparable
    {
        //定义订单号、顾客、订单总额
        [Key]
        public int OrderId { get; set; }
        public String customer { get; set; }
        public int totalMoney { get; set; }
        //多个订单明细
        public List<OrderDetails> orderDetails { get; set; }
        public Order()
        {
            orderDetails = new List<OrderDetails>();
        }
        //重写排序，默认订单号排序
        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.OrderId.CompareTo(a.OrderId);
        }

        //重写equal方法
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o.OrderId == this.OrderId;
        }
        //重写tostring方法
        public override string ToString()
        {
            return OrderId + "   " + customer + "   " + totalMoney + "   ";
        }
    }


    //订单明细类
    public class OrderDetails
    {
        //定义商品名、商品数量、商品单价
        public int OrderDetailsId { get; set; }
        public String name { get; set; }
        public int num { get; set; }
        public int price { get; set; }
        public int total { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }


        //重写equals方法
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od.num == num && od.price == price;
        }
        //重写tostring方法
        public override string ToString()
        {
            return name + "   " + num + "   " + price + "   " + num * price + "   ";
        }
    }
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDB")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
    //订单服务类
    [Serializable]
    public class OrderService
    {
        public void addOrder(Order order)
        {
            using (var db = new OrderContext())
            {

                db.Orders.Add(order);
                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public void removeOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                var currentOrder = db.Orders.Include("OrderDetails").Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                db.Orders.Remove(currentOrder);
                db.SaveChanges();
            }
        }
        public void editOrder(Order order)
        {
            using (var db = new OrderContext())
            {
                var currentOrder = db.Orders.Include("OrderDetails").Where(o => o.OrderId == order.OrderId).FirstOrDefault();
                currentOrder.customer = order.customer;
                currentOrder.orderDetails = order.orderDetails;
                currentOrder.totalMoney = order.totalMoney;
                db.Entry(currentOrder).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<Order> queryAllOrders()
        {
            using (var db = new OrderContext())
            {
                return db.Orders.Include("OrderDetails").ToList();
            }
        }

        public void export()
        {
            List<Order> os;
            using (var db = new OrderContext())
            {
                os = db.Orders.ToList();
            }
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                xmlserializer.Serialize(fs, os);
            }

        }
        public List<Order> import()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
                {
                    List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);
                    return orders;
                }
            }
            catch
            {
                return null;
            }
        }


        //查询订单        
        public List<Order> SearchByOrderId(int OrderId)
        {
            using (var db = new OrderContext())
            {
                return db.Orders.Include("OrderDetails").
                             Where(o => o.OrderId == OrderId).ToList();

            }
        }
        public List<Order> SearchByGoods(string goodsName)
        {
            using (var db = new OrderContext())
            {
                var query = db.OrderDetails.Include("Order").
                     Where(od => od.name == goodsName);
                return query.Select(od => od.Order).Include("OrderDetails").ToList();

            }
        }
        public List<Order> SearchByCustomer(string customerName)
        {
            using (var db = new OrderContext())
            {
                return db.Orders.Include("OrderDetails").
                             Where(o => o.customer == customerName).
                             OrderBy(o => o.totalMoney).ToList();

            }

        }
        public List<Order> SearchByMoney(int min, int max)
        {
            using (var db = new OrderContext())
            {
                return db.Orders.Include("OrderDetails").
                             Where(o => o.totalMoney >= min && o.totalMoney <= max).
                             OrderBy(o => o.totalMoney).ToList();

            }
        }
    }



   
}
