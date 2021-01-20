using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.Examples
{
    class AnagramCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string");
            string first = Console.ReadLine();

            Console.WriteLine("Enter second string");
            string second = Console.ReadLine();

            string isAnagram = checkAnagram(first, second) ? "Anagram" : "Not Anagram";

            Console.WriteLine($"Entered Strings {first} & {second} are {isAnagram} ");

            Console.ReadKey();
        }

        public static bool checkAnagram(string a, string b)
        {
            if(!String.IsNullOrEmpty(a) && !String.IsNullOrWhiteSpace(b) && a.Length==b.Length)
            { 
                //first Way to do -- brute force
                char[] first = a.ToCharArray();
                char[] second = b.ToCharArray();

                //int count = 0;
                //for(int i=0; i< first.Length; i++)
                //{
                //    if(b.IndexOf(first[i]) >= 0)
                //    {
                //        count++;
                //    }
                //}

                //return count == a.Length ? true : false;


                //second method -- where sort both array and check if they are equal
                a = new string(a.OrderBy(c => c).ToArray());
                b = new string(b.OrderBy(c => c).ToArray());

                return a.Equals(b) ? true : false;
            }
            else
            {
                return false;
            }

        }
    }

}
