using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class AutoResetEvents
    {
        //false means non signaled i.e. thread is not active
        static AutoResetEvent resetEvent = new AutoResetEvent(true);

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }


            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }

        static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is wating..");
            resetEvent.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing..");
            Thread.Sleep(3000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is COMPLETED..");
            resetEvent.Set();


        }
    }
}
