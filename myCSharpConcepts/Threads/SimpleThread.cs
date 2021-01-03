using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts.Threads
{
    public class SimpleThread
    {
        static void Main(string[] args)
        {
            Thread obj = new Thread(Print); //Thread object instantiation with function
            obj.Start(); //thread runs

            //Another way to start thread
            // new Thread(Print).Start();

            Console.WriteLine("Enter any key to Exit..");
            Console.ReadKey();

        }

        public static void Print() //Method that runs and prints something
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Running  {Thread.CurrentThread.ManagedThreadId} loop {i} times");
            }
        }

    }
}
