using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用工厂
            ShapeFactory factory = new ShapeFactory();
            Random random = new Random();
            double sum = 0;
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("图形" + (i + 1)+":");
                Shape shape = factory.GetShape(random.Next(0, 3));
                sum+=shape.Area();
                Console.WriteLine();
            }
            Console.WriteLine("10个图形的面积总和为" + sum);
        }
    }

    //抽象基类shape
    abstract class Shape
    {
        //初始化方法
        public abstract void Initialize();
        //面积方法
        public abstract double Area(); 
    }


    //长方形类
    class Rectangle : Shape
    {
        private double length=0;
        private double width=0;
        public Rectangle()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            while (true)
            {
                Console.WriteLine("请输入长方形的长：");
                double length = Double.Parse(Console.ReadLine());
                Console.WriteLine("请输入长方形的宽：");
                double width = Double.Parse(Console.ReadLine());
                //判断是否合法
                if (length > 0 && width > 0)
                {
                    this.length = length;
                    this.width = width;
                    break;
                }
                else
                {
                    Console.WriteLine("输入的数据非法!");
                }
            }
        }
        public override double Area()
        {
            return this.length * this.width;
        }

    }

    //正方形类
    class Square : Shape
    {
        private double rim=0;
        public Square() {
            this.Initialize();
        }
        public override void Initialize()
        {
            while (true)
            {
                Console.WriteLine("请输入正方形的边长：");
                double rim = Double.Parse(Console.ReadLine());
                //判断是否合法
                if (rim > 0)
                {
                    this.rim = rim;
                    break;
                }
                else
                {
                    Console.WriteLine("输入的数据非法!");
                }
            }
        }
        public override double Area()
        {
            return rim * rim;
        }
    }

    //三角形类
    class Triangle : Shape
    {
        private double a=0;
        private double b=0;
        private double c=0;
        public Triangle()
        {
            this.Initialize();
        }
        public override void Initialize()
        {
            while (true)
            {
                Console.WriteLine("请输入三角形边a的长：");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("请输入三角形边b的长：");
                double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("请输入三角形边c的长：");
                double c = Double.Parse(Console.ReadLine());
                //判断是否合法
                if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
                {
                    this.a = a;
                    this.b = b;
                    this.c = c;
                    break;
                }
                else
                {
                    Console.WriteLine("输入的数据非法!");
                }
            }
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            
        }
    }

    //工厂类
    class ShapeFactory
    {
        public Shape GetShape(int kind)
        {
            switch(kind)
            {
                case 0:
                    return new Rectangle();
                case 1:
                    return new Square();
                case 2:
                    return new Triangle();
                default:
                    return null;
            }
        }
    }
}
