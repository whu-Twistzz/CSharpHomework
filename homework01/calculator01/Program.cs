using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字1：");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算符：");
            string op =Console.ReadLine();
            Console.WriteLine("请输入数字2：");
            double num2 = Double.Parse(Console.ReadLine());
            double result=0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2==0)
                    {
                        break;
                    }
                    result = num1 / num2;
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        break;
                    }
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("运算符非法!");
                    return;

            }
            Console.WriteLine($"运算结果为{result}");
        }
    }
}
