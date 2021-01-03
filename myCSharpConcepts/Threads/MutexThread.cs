using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class MutexThread
    {
        static Mutex mutex = new Mutex();

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }


            // mutex.ReleaseMutex(); // doeasnot allow release of mutex from outside of scope. 
            // this is problem of Auto reset event

            Console.WriteLine("Enter any key for exit..");
            Console.ReadKey();
        }

        private static void Write()
        {
            Console.WriteLine($"Theread {Thread.CurrentThread.ManagedThreadId} waiting");
            mutex.WaitOne();
            Console.WriteLine($"Thread  {Thread.CurrentThread.ManagedThreadId} Writing");
            Thread.Sleep(4000);
            Console.WriteLine($"Thread  {Thread.CurrentThread.ManagedThreadId} writing complete..");
            mutex.ReleaseMutex();

        }
    }
}
