using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_1
{
    class Program
    {
        //判断素数
        static bool IsPrime(int num)
        {
            for (int i = 2; i <=Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数");
            int num = int.Parse(Console.ReadLine());
            List<int> primeList = new List<int>();
            Console.WriteLine(num+"的质因子如下:");
            for (int i = 2; i <= num; i++)
            {
                if (IsPrime(i) && num % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
    }
}
