using System;
using System.Collections.Generic;
using System.Collections; // dont use old collections
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // example with OLD collection
            // NO TYPE CHECKING AT COMPILE TIME
            ArrayList names = new ArrayList();
            names.Add("Rob");
            names.Add(5);
            names.Add(new object());
            names.Add(false);
            names.Add(new ArrayList());

            // NEWER GENERIC COLLECTION
            var names2 = new List<string>();
            names2.Add("STRINGS ONLY");

            do
            {
                Console.WriteLine("Enter name: ");
                string input = Console.ReadLine();
                if (input == "quit")
                    break;
                names2.Add(input);
                
            } while (true);

            foreach (string element in names2)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
