using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04_2
{
    public delegate void TimeHandler(object sender, TimeEventArgs args);
    public class TimeEventArgs
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }
    public class Clock
    {
        public event TimeHandler OnTick;
        public event TimeHandler OnAlarm;
        public int hour, minute, second;
        public int alarmHour, alarmMinute;
        public Clock(int hour,int minute,int second) 
        {
            if(hour<24&&hour>=0&&minute<60&&minute>=0&&second<60&&second>0)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }
            else
            {
                this.hour = 0;
                this.minute = 0;
                this.second = 0;
            }
        }
        public void SetTime(int alarmHour,int alarmMinute) //设置闹钟
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
        }
        public void Running()
        {
            while(true)
            {
                this.second++;
                if(this.second==60)
                {
                    this.second = 0;
                    this.minute++;
                    if (this.minute == 60)
                    {
                        this.minute = 0;
                        this.hour++;
                        if (this.hour == 24)
                            this.hour = 0;
                    }
                }
                TimeEventArgs args = new TimeEventArgs() { Hour = hour, Minute = minute, Second = second };
                if (this.hour == this.alarmHour && this.minute == this.alarmMinute)
                    OnAlarm(this,args);
                else
                    OnTick(this,args);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
    public class AlarmClock
    {
        public Clock clock;
        public AlarmClock(int hour,int minute,int second) //订阅事件
        {
            this.clock = new Clock(hour, minute, second);
            this.clock.OnTick += OnTick;
            this.clock.OnAlarm += OnAlarm;
        }
        public void OnTick(object sender,TimeEventArgs args) 
        {
            Console.WriteLine($"{args.Hour}:{args.Minute}:{args.Second}");
        }
        public void OnAlarm(object sender, TimeEventArgs args)
        {
            Console.WriteLine($"Alarm!!!!!!!Now is{args.Hour}:{args.Minute}:{args.Second}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock(16,30,30);
            alarmClock.clock.SetTime(16, 31);
            alarmClock.clock.Running();
        }
    }
}
