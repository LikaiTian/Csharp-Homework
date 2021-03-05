using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[99];
            int t = 2;
            for(int k = 0; k < 99; k++)
            {
                num[k] = t;
                t++;
            }
            for(int i = 0; i < 99; i++)
            {
                if (num[i] != 0)
                {
                    for(int j = i + 1; j < 99;j++)
                    {
                        if (num[j] % num[i] == 0)
                        {
                            num[j] = 0;
                        }
                    }
                }
            }
            foreach(int k in num)
            {
                if (k != 0)
                {
                    Console.WriteLine(k);
                }
            }

        }
    }
}
