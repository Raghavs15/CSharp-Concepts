using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    class ExtensionMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string in lower case");

            string input = Console.ReadLine();

            Console.WriteLine(input.convertToUpper()); //using extension method to convert to upper case

            Console.WriteLine($"checking if input is alphanumeric {input.checkIfAlphaNumeric()}");

            Console.ReadLine();
        }
    }


    public static class stringsEqual
    {
        public static string convertToUpper(this string a)
        {
            return a.ToUpper();
        }


        public static bool checkIfAlphaNumeric(this string a)
        {
            return a.All(char.IsLetterOrDigit) ? true : false;
        }
    }


}
