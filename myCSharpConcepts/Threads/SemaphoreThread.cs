using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class SemaphoreThread
    {
        //semaphore is number of threads allowed in execution
     static Semaphore sem = new Semaphore(1,1);

    static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            new Thread(Write).Start();
        }

        Console.WriteLine("Enter any key for exit..");
        Console.ReadKey();
    }

    private static void Write()
    {
        Console.WriteLine($"Theread {Thread.CurrentThread.ManagedThreadId} waiting");
         sem.WaitOne();
        Console.WriteLine($"Thread  {Thread.CurrentThread.ManagedThreadId} Writing");
        Thread.Sleep(4000);
        Console.WriteLine($"Thread  {Thread.CurrentThread.ManagedThreadId} writing complete..");
         sem.Release();

    }
}
}

