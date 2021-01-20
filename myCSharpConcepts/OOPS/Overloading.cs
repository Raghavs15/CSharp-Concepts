using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.OOPS
{
    class Overloading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            dynamic result = addNumbers(a,b);
            Console.WriteLine($"sum of {a} , {b} is {result}");

            dynamic result2 = addNumbers(a, b, c);
            Console.WriteLine($"sum of {a}, {b}, {c} is  {result2}");
            Console.ReadLine();

        }

        public static int addNumbers(int a, int b)
        {
            return a + b;
        }

        public static int addNumbers(int a, int b, int c)
        {
            return a + b +c;
        }

    }
}
