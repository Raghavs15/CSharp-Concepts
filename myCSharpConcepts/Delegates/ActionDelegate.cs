using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Delegates
{
    class ActionDelegate
    {
        static void Main(string[] args)
        {
            //Action accepts a method and it doesnot return any value

            Action<int> ac = Print; //Declare Action with same function parameter
            ac(1); //Invoke delegate with params

            Console.WriteLine("Enter any key to Exit..");
            Console.Read();

        }

        public static void Print(int i) //Declare function
        {
            Console.WriteLine($"Action Delegate {i}");
        }
    }

  
}
