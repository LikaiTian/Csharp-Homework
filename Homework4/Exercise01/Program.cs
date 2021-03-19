using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    //Node类
    public class Node<T> {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    //链表类
    public class List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public List()
        {
            head = tail = null;
        }
        public Node<T> GetHead()
        {
            return head;
        }
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void Foreach(Action<T> action)
        {
            Node<T> n = head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Int32> list = new List<Int32>();
            Random r = new Random();
            for(int i = 0; i < 10; i++)
            {
                int temp = r.Next(1, 10);
                list.Add(temp);
            }
            //打印链表元素
            list.Foreach(m=>Console.Write($"{m} "));
            Console.WriteLine();
            //求最大值
            int max = 0;
            list.Foreach(m => max = max > m ? max : m);
            Console.WriteLine($"Max值为{max}");
            //求最小值
            int min = 0;
            list.Foreach(m => min = min < m ? min : m);
            Console.WriteLine($"Min值为{min}");
            //求和
            int sum = 0;
            list.Foreach(m => sum += m);
            Console.WriteLine($"Sum值为{sum}");
        }
    }
}
