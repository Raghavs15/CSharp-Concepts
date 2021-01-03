using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts
{
    public delegate void PrintMessage(string msg);  //Simple Delegates

    public delegate int Math(int a, int b);     //Anonymous Method or Returned type is not void
    public class Delegate
    {
        static void Main(string[] args)
        {
            //Simple Delegates
            PrintMessage ob = PrintMsg;
            ob("Print this message 1"); //If void return type then can be called as many times without creating new instance
            ob("Print this message 2");
            ob("Print this message 3");


            //Anonymous Method delegates
            int a, b;
            Console.WriteLine("Enter Value of A");
            a = Convert.ToInt32(Console.ReadLine());   // Get First Value from User
            Console.WriteLine("Enter Value of B");
            b = Convert.ToInt32(Console.ReadLine());   // Get Second Value from User

            //sum instance of delegate
            Math sum = delegate (int c, int d) { return c + d; };
            Console.WriteLine($"Sum is {sum(a,b)}"); //Invoke Sum Delegate with user values

            //subtract instance of delegate
            Math subtract = delegate (int c, int d) { return c - d; };
            Console.WriteLine($"Subtraction is {subtract(a, b)}");   //Invoke Subtract Delegate with user values

            //multiply instance of delegate
            Math multiply = delegate (int c, int d) { return c * d; };
            Console.WriteLine($"Multiply is {multiply(a, b)}"); //Multiply Subtract Delegate with user values

            //divide instance of delegate
            Math divide = delegate (int c, int d) { return c / d; };
            Console.WriteLine($"Divide is {divide(a, b)}"); //Invoke Divide Delegate with user values

            Console.WriteLine("Enter any key to exit...");
            Console.ReadLine();
        }

        public static void PrintMsg(string message)
        {
            Console.WriteLine("Delegate invoked with : " + message);
        }
    }
}
