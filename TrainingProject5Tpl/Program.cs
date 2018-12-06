using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrainingProject5Tpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> action = runThisTask;
            //Action<object> action = (object obj) =>
            //{
            //    Console.WriteLine("Task={0}, obj={1}, Thread={2}",
            //    Task.CurrentId, obj,
            //    Thread.CurrentThread.ManagedThreadId);
            //};
            ParametersToPass parametersToPass = new ParametersToPass(1, 1000);
            //Task t1 = new Task(action, parametersToPass);
            Task t1 = Task.Factory.StartNew(action, parametersToPass);


            ParametersToPass parametersToPass1 = new ParametersToPass(2, 1500);
            //Task t2 = new Task(action, parametersToPass1);
            Task t2 = Task.Factory.StartNew(action, parametersToPass1);


            ParametersToPass parametersToPass2 = new ParametersToPass(3, 2000);
            //Task t3 = new Task(action, parametersToPass2);
            Task t3 = Task.Factory.StartNew(action, parametersToPass2);

            //t1.Start();
            //t2.Start();
            //t3.Start();
            Console.ReadKey();

        }

        private static void runThisTask(object param)
        {
            ParametersToPass paramObj = (ParametersToPass)param;
            int id = paramObj.V1;
            int sleep = paramObj.V2;
            Console.WriteLine("Task has started with id : " + Thread.CurrentThread.ManagedThreadId + " task is thread pool task : " + Thread.CurrentThread.IsThreadPoolThread + " Task is back ground Task : " + Thread.CurrentThread.IsBackground);
            Thread.Sleep(sleep);
            Console.WriteLine("Task is completed with id : " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
