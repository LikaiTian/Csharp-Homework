using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //判断
        static bool IsToeplitz(int[,] num)
        {
            int a = num.Rank;
            int b = num.GetLength(0);
            
            for(int i = 0; i < a-1; i++)
            {
                for(int j = 0; j < b-1; j++)
                {
                    if (num[i, j] != num[i + 1, j + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            Console.WriteLine(IsToeplitz(num));

        }
    }
}
