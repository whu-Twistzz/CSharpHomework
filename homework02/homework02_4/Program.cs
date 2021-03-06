using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵的行数M:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数N:");
            int col = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入一个" + row + "*" + col + "的矩阵");
            int[,] matrix= new int[row,col];
            for (int i = 0; i < row; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = int.Parse(arr[j]);
                }
            }
            for(int i=0;i<row-1;i++)
            {
                for(int j=0;j<col-1;j++)
                {
                    if(matrix[i,j]!=matrix[i+1,j+1])
                    {
                        Console.WriteLine("该矩阵不是托普利茨矩阵!");
                        return;
                    }
                }
            }
            Console.WriteLine("该矩阵是托普利茨矩阵!");
        }
    }
}
