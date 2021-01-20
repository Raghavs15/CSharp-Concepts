using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    class Generics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sum is {addNumbers<int>(a, b)}"); // GENERIC METHOD CALL VIA DECIDING <INT> OR <STRING>

            Console.WriteLine($"Sum is {addNumbers<float>(a, b)}"); // 


            Console.ReadLine();
        }

        public static T addNumbers<T>(T val1, T val2) // GENERIC METHOD 
        {
            dynamic a = val1;
            dynamic b = val2;
            return a + b;
        }
    }
}
