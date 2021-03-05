using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static int Max(int[] num)
        {
            int temp = num[0];
            foreach(int k in num)
            {
                if (temp < k)
                {
                    temp = k;
                }
            }
            return temp;
        }
        static int Min(int[] num)
        {
            int temp = num[0];
            foreach (int k in num)
            {
                if (temp > k)
                {
                    temp = k;
                }
            }
            return temp;
        }
        static double Average(int[] num)
        {
            int temp=0;
            foreach(int k in num)
            {
                temp += k;
            }
            return temp / num.Length;
        } 
        static int Sum(int[] num)
        {
            int temp = 0;
            foreach (int k in num)
            {
                temp += k;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            int[] num = new int[6] { 3, 4, 6, 2, 7, 9 };
            Console.WriteLine($"最大值为{Max(num)}");
            Console.WriteLine($"最小值为{Min(num)}");
            Console.WriteLine($"平均值为{Average(num)}");
            Console.WriteLine($"和为{Sum(num)}");

        }
    }
}
