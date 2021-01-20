using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCSharpConcepts.OOPS
{
    class Overriding
    {
        static void Main(string[] args)
        {
            Persons p = new Persons();
            p.Hands();
            p.Mouth();



            Console.ReadKey();
        }
    }


    public class Humans
    {
        public virtual void Hands()
        {
            Console.WriteLine("Humans has two hands");
        }

        public void Mouth()
        {
            Console.WriteLine("Humans has mouth");
        }
    }

    public class Persons : Humans
    {
        public override void Hands()
        {
            Console.WriteLine("Persons has mouth");
        }

        public new void Mouth()
        {
            Console.WriteLine("Persons new has mouth");
        }

    }
}
