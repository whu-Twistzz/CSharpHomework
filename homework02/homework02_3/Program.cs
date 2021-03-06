using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            const int MIN = 2;
            List<int> primeList = new List<int>();
            for (int i = MIN; i <= MAX; i++)
            {
                primeList.Add(i);
            }
            for (int i = MIN; i <=MAX; i++)
            {
                for (int j = primeList.First(); j <= primeList.Last(); j++)
                {
                    if (j % i == 0 && j != i)
                        primeList.Remove(j);
                }
            }
            Console.WriteLine("由埃氏筛法求得的2~100的素数如下:");
            foreach(int item in primeList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
