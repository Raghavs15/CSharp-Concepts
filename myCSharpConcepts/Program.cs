using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<string>
            {
                "\n There are multiple C# Classes in this project with Implementation and Clear Examples",
                "\n To Debug/Test any specific class file, follow below steps",
                "\n STEP 1: Goto Project > Properties",
                "\n STEP 2: Application > Startup Object",
                "\n STEP 3: Select Class file name > Save",
                "\n STEP 4: Debug \n"
            };

            Console.WriteLine(" \n Welcome to C Sharp Concepts by Raghav");

            Console.WriteLine(string.Join(Environment.NewLine, items));
            printStars();

            Console.WriteLine("\n Enter any key to exit..");
            Console.ReadKey();
        }

        public static void printStars()
        {
            int number, i, k, count = 1;
            number = 7;
            count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
