using System;
using System.Threading;
namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread t =new Thread(() => {
                DemoThread("Thread 1:");
            });
            t.Start();
            Thread t2 =new Thread(() => {
                DemoThread("Thread 2:");
            });
            t2.Start();
            Thread t3 =new Thread(() => {
                DemoThread("Thread 3:");
            });
            t3.Start();
            Console.WriteLine("===================================================");
            while (true)
            {
                 Thread.Sleep(1000);
                 Clock clock = new Clock();
                 clock.OnChange += () => Console.WriteLine(DateTime.Now);
                 clock.Raise();
            }
           

        }
        static void DemoThread(string threadIndex)
        {

           for (int n = 0; n <= 100; n++)
            {
               int ctr =0;
                for (int i = 2; i <= n/2; i++)
                {
                    if (n %i==0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && n !=1)
                {
                    Console.WriteLine(threadIndex+"--"+ n);
                }
            }
        }
    }
}
