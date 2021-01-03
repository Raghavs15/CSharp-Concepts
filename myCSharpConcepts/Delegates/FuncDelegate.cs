using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Delegates
{
    class FuncDelegate
    {
        static void Main(string[] args)
        {
            //Func declaration , first is input data type, second is returned data type
            Func<int, int> obj = Print; 
            int result = obj(1);
            Console.WriteLine($"Value from first func delegate is {result}");


            //First three arguments are int type expected in SumNumbers function and return type is string
            Func<int, int, int, string> obj2 = SumNumbers;
            var result2 = obj2(4, 6, 1);
            Console.WriteLine($"Value from second delegate func is {result2}");


            Console.WriteLine("Enter any key to Exit..");
            Console.ReadKey();
        }


        public static int Print(int i)
        {
            return i + 1;

        }

        //function having string return type and params in int type
        public static string SumNumbers(int a, int b, int c)
        {
            return $" Sum of {a} , {b}, {c} is {a + b + c}";
        }

    }
}
