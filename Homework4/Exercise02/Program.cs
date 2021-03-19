using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise02
{   //定义事件处理函数
    public delegate void ClockHandler(Object sender, TickEventsArgs args1, AlarmEventArgs args2);
    //定义参数类
    public class TickEventsArgs { }
    public class AlarmEventArgs {
        public string Time { get; set; }
    }
   
    public class Clock { 
    
        //声明事件
        public event ClockHandler OnClock;

        //触发事件
        public void On_Clock()
        {
            TickEventsArgs args1 = new TickEventsArgs();

            AlarmEventArgs args2 = new AlarmEventArgs()
            {
                Time = "19:56:00"
            };
            OnClock(this, args1, args2);
           
        }
            
    }

    public class Form
    {
        public Clock clock = new Clock();

        public Form()
        {
            clock.OnClock += Clock_OnClock2;
        }
        void Clock_OnClock2(Object sender, TickEventsArgs args1,AlarmEventArgs args2)
        {
            String s1 = DateTime.Now.ToString("T");
            Console.WriteLine("现在时间是："+s1);
            if (s1 == args2.Time)
            {
                Console.WriteLine("闹钟响了");
            }
            
            Thread.Sleep(1000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            while (true)
            {
                form.clock.On_Clock();
            }
        }
    }
}
