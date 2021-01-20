using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.OOPS
{
    class Abstraction 
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Id = 1;
            person.Name = "Ram";
            person.Speaker();
           // person.Details();


            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
    }

    public abstract class Mouth
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Speaker();

        public void Details()
        {
            Console.WriteLine($"Non abstarct method");
        }
    }

    public class Person : Mouth
    {
        public override void Speaker()
        {
            Console.WriteLine($"Person {Id}, {Name} Speaks");
        }
    }
}
