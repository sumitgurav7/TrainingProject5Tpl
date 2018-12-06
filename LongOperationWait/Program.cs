using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongOperationWait
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() => {
                Random rnd = new Random();
                long sum = 0;
                long n = 50000000;
                for (long ctr = 1; ctr <= n; ctr++)
                {
                    int number = rnd.Next(0, 101);
                    sum += number;
                }
                Console.WriteLine("Total:   {0:N0}", sum);
                Console.WriteLine("Mean:    {0:N2}", sum / n);
                Console.WriteLine("N:       {0:N0}", n);
            });
            TimeSpan ts = TimeSpan.FromMilliseconds(200000);
            //if (!t.Wait(ts))
            //{ Console.WriteLine("The timeout interval elapsed." + t.Wait(ts)); }

            Console.ReadKey();
        
    }
    }
}
