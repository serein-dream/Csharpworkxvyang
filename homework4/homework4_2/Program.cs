using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4_2
{

    public class Timeargs
    {
        public int Hour_ { get; set; }
        public int Minute_ { get; set; }
        public int Second_ { get; set; }
    }

    //声明委托类型
    public delegate void Tickhandler(object sender, Timeargs time);
    public delegate void Alarmhandler(object sender, Timeargs time);

    public class NormalClock
    {
        public int Hour, Minute, Second, Alarm_h, Alarm_m, Alram_s;
        public event Tickhandler ToTick;
        public event Alarmhandler ToAlarm;

        public NormalClock(int h, int m, int s)
        {
            int t = 1;
            while (t == 1)
            {
                if (h >= 0 && h < 25 && m >= 0 && m < 60 && s >= 0 && s < 60)
                {
                    Hour = h;
                    Minute = m;
                    Second = s;
                    t = 0;
                }
                else
                {
                    Console.WriteLine("输入时间不合常规，请重新输入：");
                }
            }
        }

        public void SetAlarm(int h_,int m_,int s_)
        {
            Alarm_h = h_;
            Alarm_m = m_;
            Alram_s = s_;
        }

        public void going()
        {
            while (!(Hour == Alarm_h && Minute == Alarm_m && Second == Alram_s))
            {
                Second += 1;
                if (Second == 60)
                {
                    Second = 0;
                    Minute += 1;
                }
                if (Minute == 60)
                {
                    Minute = 0;
                    Hour += 1;
                }
                if (Hour == 24)
                {
                    Hour = 0;
                }
                Timeargs time_tick = new Timeargs() { Hour_ = Hour, Minute_ = Minute, Second_ = Second };
                ToTick(this, time_tick);
            }
            Timeargs time_alarm = new Timeargs() { Hour_ = Hour, Minute_ = Minute, Second_ = Second };
            ToAlarm(this, time_alarm);
            System.Threading.Thread.Sleep(1000);
        }
    }

    //事件发布者和监听者区分开
    public class Myclock
    {
        public NormalClock myclock;

        void  ToTick(object sender,Timeargs time)
        {
            Console.WriteLine($"Tick!：[ { time.Hour_} : { time.Minute_ } : { time.Second_ }]");
        }
        void ToAlarm(object sender, Timeargs time)
        {
            Console.WriteLine($"Alarm!：[ { time.Hour_} : { time.Minute_ } : { time.Second_ }]");
        }
        public Myclock (int H_my,int M_my,int S_my)
        {
            myclock = new NormalClock(H_my, M_my, S_my);
            myclock.ToTick += ToTick;
            myclock.ToAlarm += ToAlarm;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int again = 1;
            while (again == 1)
            {
                Console.WriteLine("请依次输入现在的时，分，秒，闹钟的时，分，秒，用回车隔开每个数： ");
                int Now_h = int.Parse(Console.ReadLine());
                int Now_m = int.Parse(Console.ReadLine());
                int Now_s = int.Parse(Console.ReadLine());
                int Alarm_h = int.Parse(Console.ReadLine());
                int Alarm_m = int.Parse(Console.ReadLine());
                int Alarm_s = int.Parse(Console.ReadLine());
                Myclock myclock = new Myclock(Now_h, Now_m, Now_s);
                myclock.myclock.SetAlarm(Alarm_h, Alarm_m, Alarm_s);
                myclock.myclock.going();
                Console.WriteLine("输入0结束程序，输入1再来一次：");
                again = int.Parse(Console.ReadLine());
            }

        }
    }
}
