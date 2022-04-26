using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class stopwatch
    {
        public void StopWatch()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new();

            Console.WriteLine("Press 1 to start : ");
            int start = Convert.ToInt32(Console.ReadLine());
            if (start == 1)
            {
                stopwatch.Start();
            }

            // calculate time
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1);
            }

            Console.WriteLine("Press 2 to stop : ");
            int stop = Convert.ToInt32(Console.ReadLine());
            if (stop == 2)
            {
                stopwatch.Stop();
            }

            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
