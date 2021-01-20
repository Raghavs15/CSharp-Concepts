using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myCSharpConcepts.Examples
{
    class FileReader
    {
        static void Main(string[] args)
        {
            //get file path
            string _filePath =  Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            //instantiate reader object with filename
            StreamReader reader = new StreamReader(_filePath+ @"\data.txt");

            //read contents and display
            Console.WriteLine(reader.ReadToEnd());
            
            reader.Close();


            Console.ReadKey();
        }
    }
}
