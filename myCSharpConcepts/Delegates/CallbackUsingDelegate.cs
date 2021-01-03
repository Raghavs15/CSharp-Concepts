using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace myCSharpConcepts
{
    public class CallbackUsingDelegate
    {
        static void Main(string[] args)
        {
            TimeConsuming obj = new TimeConsuming();

            var th = new Thread(() => obj.BigTask(Write));
            th.Start();

            Console.WriteLine("Main thread is executing");
            Console.Read();
        
        }

        public static void Write(int i)
        {
            Console.WriteLine($"Callback value is {i}");
        }
    }


    //Consider this as a time consuming operation/logic
    class TimeConsuming
    {

        public delegate void HandleWork(int a);

        public void BigTask(HandleWork work)
        {
            //Mimic 5 seconds of delay
            Thread.Sleep(5000);
            work(400); //call back
            Console.WriteLine("Called back in main thread");
        }

    }
}
