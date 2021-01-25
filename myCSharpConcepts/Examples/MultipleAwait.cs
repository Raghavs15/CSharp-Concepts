using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    class MultipleAwait
    {
        static async Task Main(string[] args)
        {
           await Calling();
                // Do any async anything you need here without worry
         

            Console.ReadKey();
        }

       static async Task Calling()
        {
            await Task.Delay(5000);
            Console.WriteLine("First");


            await Task.Delay(3000);
            Console.WriteLine("secod");


            await Task.Delay(1000);
            Console.WriteLine("third");
        }
    }
}
