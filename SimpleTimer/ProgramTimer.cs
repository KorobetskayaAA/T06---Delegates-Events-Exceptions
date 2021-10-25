using System;

namespace SimpleTimer
{
    class Timer
    {
        public Timer(int notifyTimeMs, Action<string> action)
        {
            action($"Timer started at {DateTime.Now}");
            DateTime endTime = DateTime.Now.AddMilliseconds(notifyTimeMs);
            while (DateTime.Now < endTime) ;
            action($"Timer finished at {endTime}");
        }
    }

    class ProgramTimer
    {
        static void Main(string[] args)
        {
            new Timer(5000, Console.WriteLine);
            new Timer(10000, Console.WriteLine);

        }
    }
}
