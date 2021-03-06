using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数组(空格隔开):");
            //直接读取数组
            List<int> numList = new List<int>();
            string[] arr = Console.ReadLine().Split(' ');
            int max, min;
            double avg = 0;
            int sum = 0;
            //转化为数字
            foreach (string str in arr)
            {
                if (str != "")
                    numList.Add(int.Parse(str));
            }
            max = numList.First();
            min = numList.First();
            foreach (int item in numList)
            {
                if (item > max)
                    max = item;
                if (item < min)
                    min = item;
                avg += item;
                sum += item;
            }
            avg = avg / numList.Count;
            Console.WriteLine("数组的最大值为:" + max);
            Console.WriteLine("数组的最小值为:" + min);
            Console.WriteLine("数组的平均值为:" + avg);
            Console.WriteLine("数组的数字之和为:" + sum);
        }
    }
}
