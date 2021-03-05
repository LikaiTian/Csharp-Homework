using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static bool Div(int num)
        {
            int sqat = (int)Math.Sqrt(num);
            for(int i = 2; i <= sqat; i++)
            {
                while (num % i == 0)
                {
                    num /= i;
                    Console.WriteLine(i);
                }
                if (num == 1) { return true; }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数据：");
            int num = Convert.ToInt32(Console.ReadLine());
            if (Div(num) == false)
            {
                Console.WriteLine("这是一个素数");
            }
        }
    }
}
