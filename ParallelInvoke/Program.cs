using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ParallelInvoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => test1(), () => test2(), () => test3());
            Console.WriteLine("main thread exiting");
            Console.ReadKey();
        }

        private static void test3()
        {
            
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
           // Console.WriteLine(milliseconds);
            Console.WriteLine("Parallel process 3 with thread id : " + Thread.CurrentThread.ManagedThreadId + " time "+ milliseconds + " Ticks " + DateTime.Now.Ticks);
        }

        private static void test2()
        {
            
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
           // Console.WriteLine(milliseconds);
            Console.WriteLine("Parallel process 2 with thread id : " + Thread.CurrentThread.ManagedThreadId + " time " + milliseconds + " Ticks " + DateTime.Now.Ticks);
        }

        private static void test1()
        {
            
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));

            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
           // Console.WriteLine(milliseconds);
            Console.WriteLine("Parallel process 1 with thread id : " + Thread.CurrentThread.ManagedThreadId + " time " + milliseconds + " Ticks " + DateTime.Now.Ticks);

        }
    }
}
