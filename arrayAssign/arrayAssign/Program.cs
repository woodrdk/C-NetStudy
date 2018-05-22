using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1 method should repeatedly ask a user for a number (up to 10 total numbers) or they can stop early by entering 0
            //      This method should return an array with the users input numbers
            //  1 method should take an array as a parameter, copy that array and double each element, and return the copy array
            //  1 method should display the original array and the copy array with the doubled values afterwards
            //  *** Write the program without any class scoped variables***
            //  To make this easier, if the user does not enter all 10 numbers you do not have to keep track of the exact number they entered
            //  For more of a challenge you can grow the array as the user is entering numbers

            Console.WriteLine();
            int count = 0;
            int[] myList = new int[10];
            while (count < 10) {
                Console.WriteLine("Please input a number or press 0 to end.");
                Console.ReadKey();
                myList[count] = Int32.Parse(Console.ReadLine());
                count++;
            }

            //int[] myListCopy = myList[10];

        }

        public void display( int [] myList, int [] myListCopy){ 
            // display method
            string myListString = String.Join(",", myList.Select(p => p.ToString()).ToArray());
            string myListCopyString = String.Join(",", myListCopy.Select(p => p.ToString()).ToArray());
            Console.WriteLine(" The original array " + myListString);
            Console.WriteLine();
            Console.WriteLine(" The doubled copy array " + myListCopyString);
            Console.ReadKey();

            Console.WriteLine("or");
            PrintIndexAndValues(myList);
            PrintIndexAndValues(myListCopy);
        }

        private void PrintIndexAndValues(Array myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++) { 
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
            }

        }
    }
}
