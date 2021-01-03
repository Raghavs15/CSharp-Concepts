using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts
{
    class MulticastDelegate
    {
        public delegate void PrintMessage(string text); //Delegate with Void Return Type

        static void Main(string[] args)
        {
            PrintMessage print; //Instance of Delegate

            print = Print1; // assignment to function with same signature
            print += Print2; // adding function using + = operator
            print += Print3;

            print("Multicast += or + Delegate"); // delegate invoked

            print -= Print2; // subtracting Print 2 function from delegate
            print("Multicast - operator to remove Method 2"); // delegate invoked

            Console.Read();
        }

        public static void Print1(string txt)
        {
            Console.WriteLine($"First Method : {txt}");
        }

        public static void Print2(string txt)
        {
            Console.WriteLine($"Second Method : {txt}");
        }


        public static void Print3(string txt)
        {
            Console.WriteLine($"Third Method : {txt}");
        }

    }
}
