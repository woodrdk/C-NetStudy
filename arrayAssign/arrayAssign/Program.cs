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
            Console.WriteLine();
            int [] myNums = askFor(10);
            int [] myNumCopy = copyDouble(myNums);
            display(myNums, myNumCopy);
            Console.ReadKey();
        }
        public static int[] askFor(int elementCount) {

            // 1 method should repeatedly ask a user for a number (up to 10 total numbers) or they can stop early by entering 0
            //      This method should return an array with the users input numbers

            int[] myNums = new int[elementCount];
            int count = 0;
            while(count < 10)
            {
                if (count < 10)
                {
                    Console.WriteLine("Please input a number or press 0 to end.");
                    string Num = Console.ReadLine();
                    int newNum;
                    bool res = Int32.TryParse(Num, out newNum);
                    if (newNum == 0) {
                        count = 10;
                    }
                    else {
                        myNums[count] = newNum;
                    }        
                }
                count++;
            }
            
            return myNums.Where(i => i != 0).ToArray();

        }

        public static int[] copyDouble(int[] myNums) {
            //  1 method should take an array as a parameter, copy that array and double each element, and return the copy array

            int[] myNumCopy = new int [myNums.Length];
            Array.Copy(myNums, myNumCopy, myNums.Length);
            for (int i = 0; i < myNumCopy.Length; i++) {
                myNumCopy[i] = (myNums[i] * 2);
            }
            return myNumCopy;
        }

        //  1 method should display the original array and the copy array with the doubled values afterwards
        
        public static void display(int[] myNums, int [] myNumCopy){
            // display method
            
            string myNumString = String.Join(" ", myNums.Select(p => p.ToString()).ToArray());
            string myNumCopyString = String.Join(" ", myNumCopy.Select(p => p.ToString()).ToArray());
            Console.WriteLine(" The original array " + myNumString);
            Console.WriteLine();
            Console.WriteLine(" The doubled copy array was this " + myNumString + " and became this " + myNumCopyString);
            Console.ReadKey();

            Console.WriteLine("or");
            
        }


        //  *** Write the program without any class scoped variables***
        //  To make this easier, if the user does not enter all 10 numbers you do not have to keep track of the exact number they entered
        //  For more of a challenge you can grow the array as the user is entering numbers
    }
}
