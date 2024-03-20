using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Clock
    {
        const int DEADLINE = 7;    //第7秒响铃

        public event EventHandler Tick;
        public event EventHandler Alarm;

        public void start()
        {
            Console.WriteLine("clock is running...");

            int count = 0;
            while (true)
            {
                Thread.Sleep(1000);

                Tick(this,EventArgs.Empty);
                Console.WriteLine(++count);

                if (count == DEADLINE)
                {
                    Alarm(this, EventArgs.Empty);
                    return;
                }
            }
        }
    }
}
