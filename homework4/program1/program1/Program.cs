using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class ClockTimeArgs:EventArgs
    {
        public int Hour, Minute, Second;
    }

    public delegate void ClockTimeHandler(object sender, ClockTimeArgs e);

    public class Clock
    {
        public event ClockTimeHandler Run;

        int H, M, S;

        public void SetClock()
        {
            H = Convert.ToInt32( Console.ReadLine());
            M = Convert.ToInt32(Console.ReadLine());
            S = Convert.ToInt32(Console.ReadLine());

        }

        public void DoRun()//获取现在的时间，比较小时、分、秒
        {
            System.DateTime currentTime = new System.DateTime();
           
            ClockTimeArgs args = new ClockTimeArgs();

            int time = 0;
            while (time<24*60*60)
            {
                time++;

                int hour = DateTime.Now.Hour;
                int minute = DateTime.Now.Minute;
                int second = DateTime.Now.Second;

                System.Threading.Thread.Sleep(1000);

           

                if ((hour < H) || (minute<M) || (second<S))
                {
                    Run(this, args);
                }
                if (hour>=H&&minute>=M&&second>=S)
                {
                    Console.WriteLine("闹钟到了！！");
                    Console.WriteLine("/a");
                }

            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();
            clock.SetClock();
            clock.Run += ShowTime;
           
            clock.DoRun();
        }

        static void ShowTime(object sender, ClockTimeArgs e)
        {
            Console.WriteLine("Clock is run . . ." );
        }
    }
   
}
