using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    public class YeildSample
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("sum of incremental numbers are");

            foreach(int i in AddNums())
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

       public static IEnumerable<int> AddNums()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };

            int sum = 0;
            foreach(int i in numbers)
            {
                sum = sum + i;
                yield return sum;
            }
        }
    }
}
