using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class Lock
    {
        private static object _locker = new object(); //create static object since there is no instance of class we are creating

        static void Main(string[] args)
        {
            
            for (int i = 0; i < 5; i++)
            {
                new Thread(BigTask).Start(); //New Thread execution
            }


            Console.WriteLine("Enter any key to Exit..");
            Console.ReadKey();

        }

        public static void BigTask()
        {
            lock (_locker) //This will stop concurrent thread executions. Only one thread will be allowed at a time
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed..");
            }

            //If any exception happens in lock then it'll not be handled
        }
    }
}
