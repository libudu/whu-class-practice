using System;

namespace practice4_2
{

    //声明一个委托类型，定义事件处理函数的格式 
    public delegate void ClickHandler(object sender);
    
    public class Clock
    {
        //定义事件
        public event ClickHandler OnTick;
        public event ClickHandler OnAlarm;
        
        //闹铃的时间
        private int minute;
        private int second;

        //初始化闹钟，设置好时间
        public Clock(int minute, int second)
        {
            this.minute = minute;
            this.second = second;
        }

        public void ClockTimePass(int minute, int second)
        {
            if(this.minute == minute && this.second == second)
            {
                OnAlarm(this);
            }
            else
            {
                OnTick(this);
            }
        }
    }

    public class Form
    {
        public Clock clock1 = new Clock(0, 5);

        //当前的时间
        private int minute;
        private int second;

        //构造Form，时间初始为0，添加事件处理方法
        public Form()
        {
            minute = 0;
            second = 0;
            //为btn的OnClick事件添加两个处理方法
            clock1.OnTick += Clock_Tick;
            clock1.OnAlarm += Clock_Alarm;
        }

        //该Form过去一秒
        public void SecondPass()
        {
            second += 1;
            if (second >= 60)
            {
                minute += 1;
                second = 0;
            }
            clock1.ClockTimePass(minute, second);
        }

        void Clock_Tick(object sender)
        {
            Console.WriteLine("doki doki ...");
        }

        void Clock_Alarm(object sender)
        {
            Console.WriteLine("beeeeee!beeeeee!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form1 = new Form();
            while (true)
            {
                form1.SecondPass();
                System.Threading.Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}
