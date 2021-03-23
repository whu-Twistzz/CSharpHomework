using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> inilist = new GenericList<int>();
            for(int i=0;i<10;i++)
            {
                inilist.Add(i);
            }
            Console.WriteLine("打印链表元素:");
            inilist.ForEach(m => Console.Write(m+" "));
            Console.WriteLine();
            int max = 0;
            inilist.ForEach(m => { if (m > max) max = m; });
            Console.WriteLine($"最大值:{max}");
            int min = 0;
            inilist.ForEach(m => { if (m < min) min = m; });
            Console.WriteLine($"最小值:{min}");
            int sum = 0;
            inilist.ForEach(m => sum += m);
            Console.WriteLine($"和:{sum}");

        }
    }
}
