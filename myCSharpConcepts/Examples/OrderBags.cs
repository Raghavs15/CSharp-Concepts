using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    public class OrderBags
    {
        static void Main(string[] args)
        {
            int[] bags = { 5, 10, 15 , 3};
            int totalCount = bags.Length;
            Console.WriteLine("Enter no of bags needed");

            int order = Convert.ToInt32(Console.ReadLine());

            if (order == 0) Console.WriteLine("INVALID ORDER");


            for (int i = 0; i < totalCount; i++)
                for (int j = i + 1; j < totalCount; j++)
                    if (bags[i] + bags[j] == order)
                        Console.Write("(" + bags[i] + ", " + bags[j] + ")"
                                      + "\n");

            Console.ReadLine();

        }

         
    }
}
