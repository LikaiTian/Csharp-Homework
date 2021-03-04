using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入第一个数:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("输入第二个数:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = 0;
            Console.WriteLine("输入运算符:");
            string s = Console.ReadLine();
            switch (s) {
                case "+":c = a + b;break;
                case "-":c = a - b;break;
                case "*":c = a * b;break;
                case "/":c = a / b;break;
            }
            Console.WriteLine($"运算结果为{c}");

        }
    }
}
