using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework06_1
{
    //订单类
   public class Order : IComparable
    {
        //定义订单号、顾客、订单总额
        private int id { get; set; }
        private String customer { get; set; }
        private int totalMoney { get; set; }
        //多个订单明细
        public List<OrderDetails> orderDetails = new List<OrderDetails>();
        public Order(int id, String customer, int totalMoney)
        {
            this.id = id;
            this.customer = customer;
            this.totalMoney = totalMoney;
        }
        public int getId()
        {
            return this.id;
        }
        public int getMoney()
        {
            return this.totalMoney;
        }
        public string getCustomer()
        {
            return this.customer;
        }
        public void setMoney()
        {
            foreach (OrderDetails od in orderDetails)
            {
                this.totalMoney += od.getAllMoney();
            }
        }
        //重写排序，默认订单号排序
        public int CompareTo(object obj)
        {
            Order a = obj as Order;
            return this.id.CompareTo(a.getId());
        }
        //订单明细中是否存在指定商品
        public bool searchGoods(string name)
        {
            foreach (OrderDetails a in this.orderDetails)
            {
                if (a.getName() == name)
                    return true;
            }
            return false;
        }
        //添加订单明细
        public void addOrderDetails(string name, int number, int price)
        {
            OrderDetails od = new OrderDetails(name, number, price);
            foreach (OrderDetails o in orderDetails)
            {
                if (o.Equals(od))
                {
                    Console.WriteLine("订单明细重复,添加失败!");
                    return;
                }
            }
            this.orderDetails.Add(od);
        }
        //删除订单明细
        public void removeOrderDetails()
        {
            try
            {
                Console.WriteLine("请输入要删除的订单明细序号：");
                int a = Convert.ToInt32(Console.ReadLine());
                this.orderDetails.RemoveAt(a);
                Console.WriteLine("删除成功");

            }
            catch
            {
                Console.WriteLine("删除订单明细失败！");
            }
        }
        //打印所有订单明细
        public void showOrderDetails()
        {
            Console.WriteLine("名称  数量  单价  总价");
            foreach (OrderDetails a in this.orderDetails)
            {
                Console.WriteLine(a);
            }
        }
        //重写equal方法
        public override bool Equals(object obj)
        {
            Order o = obj as Order;
            return o.id == this.id;
        }
        //重写tostring方法
        public override string ToString()
        {
            return id + "   " + customer + "   " + totalMoney + "   ";
        }
    }


    //订单明细类
    public class OrderDetails
    {
        //定义商品名、商品数量、商品单价
        private String name { get; set; }
        private int num { get; set; }
        private int price { get; set; }
        public OrderDetails(String name, int num, int price)
        {
            this.name = name;
            this.num = num;
            this.price = price;
        }
        public int getAllMoney()
        {
            return num * price;
        }
        public string getName()
        {
            return name;
        }
        //重写equals方法
        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od.name.Equals(name) && od.num == num && od.price == price;
        }
        //重写tostring方法
        public override string ToString()
        {
            return name + "   " + num + "   " + price + "   " + num * price + "   ";
        }
    }

    //订单服务类
    [Serializable]
   public class OrderService
    {
        //定义订单集合
        public List<Order> orders = new List<Order>();
        //打印所有订单及其明细
        public void showAllOrder()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("订单号  客户名  总金额");
                Console.WriteLine(o);
                o.showOrderDetails();
                Console.WriteLine("----------------------------------------");
            }
        }
        public void export()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                xmlserializer.Serialize(fs, this.orders);
            }
            Console.WriteLine("订单序列化完成!");
        }
        public void import()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
                {
                    List<Order> orders = (List<Order>)xmlSerializer.Deserialize(fs);
                    Console.WriteLine("反序列化结果如下:");
                    foreach (Order o in orders)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("订单号  客户名  总金额");
                        Console.WriteLine(o);
                        o.showOrderDetails();
                        Console.WriteLine("----------------------------------------");
                    }
                }
            }
            catch
            {
                Console.WriteLine("反序列化失败!");
            }
        }
        //添加订单
        public void addOrder()
        {
            try
            {
                Console.WriteLine("请输入订单编号：");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入客户名称：");
                string customer = Console.ReadLine();
                Order order = new Order(id, customer, 0);
                Console.WriteLine("输入订单项：");
                bool isSame = false;
                foreach (Order or in orders)
                {
                    if (or.Equals(order)) isSame = true;
                }
                if (isSame)
                    Console.WriteLine("订单号重复!");
                else
                {
                    while (true)
                    {
                        Console.WriteLine("请输入物品名称：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入购买数量：");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入单价：");
                        int price = Convert.ToInt32(Console.ReadLine());
                        order.addOrderDetails(name, number, price);
                        Console.WriteLine("继续添加订单明细?(Y/N)");
                        string isContinue = Console.ReadLine();
                        if (isContinue == "N") { order.setMoney(); break; }
                        else if (isContinue == "Y") continue;
                    }
                }
                orders.Add(order);
                Console.WriteLine("创建新订单成功!");
            }
            catch
            {
                Console.WriteLine("创建失败!");
            }
        }
        //删除订单
        public void removeOrder()
        {
            try
            {
                Console.WriteLine("输入订单号删除订单或相应明细：");
                int id = Convert.ToInt32(Console.ReadLine());
                int index = 0;
                foreach (Order a in this.orders)
                {
                    if (a.getId() == id)
                        index = this.orders.IndexOf(a);
                }
                Console.WriteLine("输入1删除订单，输入2继续删除订单明细");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: this.orders.RemoveAt(index); Console.WriteLine("删除成功"); break;
                    case 2: this.orders[index].showOrderDetails(); this.orders[index].removeOrderDetails(); break;
                    default: Console.WriteLine("输入错误"); break;
                }
            }
            catch
            {
                Console.WriteLine("删除失败!");
            }
        }
        //查询订单
        public List<Order> SearchOrder()
        {
            Console.WriteLine("1.根据订单号查询订单\n2.根据商品名查询订单\n3.根据客户名查询订单\n4.根据订单金额查询订单\n");
            int i = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (i)
                {
                    //根据订单号查询订单
                    case 1:
                        Console.WriteLine("请输入订单号:");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        var query1 = from s1 in orders
                                     where s1.getId() == searchId
                                     select s1;
                        List<Order> orderlist1 = query1.ToList();
                        foreach (Order o in orderlist1)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("订单号  客户名  总金额");
                            Console.WriteLine(o);
                            o.showOrderDetails();
                            Console.WriteLine("----------------------------------------");
                        }
                        return orderlist1;
                        break;
                    //根据商品名查询订单
                    case 2:
                        Console.WriteLine("请输入商品名:");
                        string goodsName = Console.ReadLine();
                        var query2 = from s2 in orders
                                     where s2.searchGoods(goodsName)
                                     orderby s2.getMoney()
                                     select s2;
                        List<Order> orderlist2 = query2.ToList();
                        foreach (Order o in orderlist2)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("订单号  客户名  总金额");
                            Console.WriteLine(o);
                            o.showOrderDetails();
                            Console.WriteLine("----------------------------------------");
                        }
                        return orderlist2;
                        break;
                    //根据客户名查询订单
                    case 3:
                        Console.WriteLine("请输入客户名:");
                        string customerName = Console.ReadLine();
                        var query3 = from s3 in orders
                                     where s3.getCustomer() == customerName
                                     orderby s3.getMoney()
                                     select s3;
                        List<Order> orderlist3 = query3.ToList();
                        foreach (Order o in orderlist3)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("订单号  客户名  总金额");
                            Console.WriteLine(o);
                            o.showOrderDetails();
                            Console.WriteLine("----------------------------------------");
                        }
                        return orderlist3;
                        break;
                    //根据订单金额查询订单
                    case 4:
                        Console.WriteLine("请输入要查询的金额范围:");
                        Console.WriteLine("最小值:");
                        int min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("最大值:");
                        int max = Convert.ToInt32(Console.ReadLine());
                        var query4 = from s4 in orders
                                     where s4.getMoney() > min && s4.getMoney() < max
                                     orderby s4.getMoney()
                                     select s4;
                        List<Order> orderlist4 = query4.ToList();
                        foreach (Order o in orderlist4)
                        {
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("订单号  客户名  总金额");
                            Console.WriteLine(o);
                            o.showOrderDetails();
                            Console.WriteLine("----------------------------------------");
                        }
                        return orderlist4;
                        break;
                    default:
                        return null;
                }
            }
            catch
            {
                Console.WriteLine("查询失败!");
                return null;
            }
        }
        //排序方法，默认订单号
        public void sortOrders()
        {
            orders.Sort();
        }
        public void sortOrders(Comparison<Order> func)
        {
            orders.Sort(func);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            OrderService os = new OrderService();
            while (!isQuit)
            {
                Console.WriteLine("\n请输入序号，选择功能:");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("1.显示所有订单\n2.添加订单\n3.删除订单\n4.查询订单\n5.订单排序\n6.退出\n");
                Console.WriteLine("--------------------------------------------------");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: os.showAllOrder(); break;
                    case 2: os.addOrder(); break;
                    case 3: os.removeOrder(); break;
                    case 4: os.SearchOrder(); break;
                    case 5: os.sortOrders(); break;
                    case 6: isQuit = true; break;
                    default: Console.WriteLine("输入的序号有误，请重新输入!"); break;
                }
            }
        }
    }
}
