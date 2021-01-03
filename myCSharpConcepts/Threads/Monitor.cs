using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    class MonitorThread
    {
        private static object _locker = new object(); //create static object since there is no instance of class we are creating
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(BigTask).Start();
            }


            Console.WriteLine("Enter any key to Exit..");
            Console.ReadKey();

        }


        public static void BigTask()
        {
            try
            { //Exception handling of thread can be done using Monitor

                Monitor.Enter(_locker); //Start Monitor of THREAD using object
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed..");
            
            }catch(Exception ex)
            {
                //Handle exception, log error message or do some work'
                throw ex;
            }
            finally
            {
                //release monitor
                Monitor.Exit(_locker);

            }

        }
    }
}
