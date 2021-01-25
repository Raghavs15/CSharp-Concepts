using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    public class FibonacciSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number till you want fibonacci");
            int maxVal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Fibonacci series till {maxVal} are");

            foreach(int i in fibonacci(maxVal))
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }


        public static IEnumerable<int> fibonacci(int maxval)
        {
            int series = 0;
            for(int i=0; i < maxval; i++)
            {
                yield return series + i;
            }
        }
    }
}
