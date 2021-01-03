using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class ManualResetEvents
    {
        //Manual reset event instantiation
        static ManualResetEvent ob = new ManualResetEvent(false);
         
        static void Main(string[] args)
        {
            new Thread(Write).Start();

            for (int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }

            Console.WriteLine("Enter any key to Exit..");
            Console.ReadKey();
        }

        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is writing");
            ob.Reset();
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} writing completed");
            ob.Set();

        }


        public static void Read()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is waiting");
            ob.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} reading complete");


        }
    }
}
