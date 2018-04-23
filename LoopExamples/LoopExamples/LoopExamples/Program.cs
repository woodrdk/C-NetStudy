using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            /*
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }


            int value = 0;
            while (true)
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    break;
                }
            }
            Console.WriteLine("Thanks for " + value);
            Console.WriteLine($"Thanks for {value}");
            */
            // the foreach and the for that follows are the same  just diff style
            /*
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            */
            /*
            string userInput = "";
            do
            {
                Console.WriteLine("Choose an option");
                userInput = Console.ReadLine();
            } while (userInput !="q");
            */
            /*
            // while loop example
            int sum = 0;
            int counter = 1;
            while(counter <= 10)
            {
                sum += counter;
                counter++;
            }
            Console.WriteLine(sum);
            Console.WriteLine("");
            */

            /*
            // for loop example
            for (int currIndex = 0; currIndex < args.Length; currIndex++)
            {
                Console.WriteLine(args[currIndex]);
                Console.WriteLine("");
            }
            Console.ReadKey();
            */


            // Control structure exercises
            // Exercise 1 : Using loops write C# code to produce the following output:
            // 1
            // 22      
            // 333
            // 4444
            // 55555
            // 666666
            Console.WriteLine("Exercise 1 :");
            Console.WriteLine();
            int howManyNum = 6;
            for (int numLoop = 1; numLoop <= howManyNum; numLoop++)
            {
                for (int i = 0; i < numLoop; i++)
                {
                    Console.Write(numLoop);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.WriteLine();
            // Exercise 2 : Using loops write C# code to produce the output shown below:
            // *******
            // ******
            // *****
            // ****
            // ***
            // **
            // *
            Console.WriteLine("Exercise 2 :");
            Console.WriteLine();
            int manyStars = 7;
            for (int numLoop = manyStars; numLoop > 0; numLoop--)
            {
                for (int i = numLoop; i > 0; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            // Exercise 3 : Using loops write C# code to produce the following output below:
            // \......../
            // \\......//
            // \\\....///
            // \\\\..////
            // \\\\\/////
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Exercise 3 :");
            Console.WriteLine();
            int manyLines = 5;
            for (int numLoop = 1; numLoop <= manyLines; numLoop++)
            {
                for (int i = 1; i <= numLoop; i++)
                {
                    Console.Write("\\");
                }
                for (int j = manyLines; j > 1; j--)
                {
                    Console.Write(".");
                }

                for (int i = 1; i <= numLoop; i++)
                {
                    Console.Write("/");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Exercise 4A");
            Console.WriteLine();
            Console.WriteLine("Enter an integer");
            string input = Console.ReadLine();
            int numberInput = Int32.Parse(input);
            if(numberInput < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }
            Console.ReadKey();


            // need to finish 4B
            // Using the above programs code, modify it using a while
            // loop to get a final total of all input. Print out the total and average.
            // Repeatedly ask the user for a number until they want to quit. 
            // (q to quit, entering a 0, or a different value to stop)
            //
                        Console.WriteLine();
            Console.WriteLine("Exercise 4B");
            Console.WriteLine();
            Console.WriteLine("Enter an integer");
            string input = Console.ReadLine();
            int numberInput = Int32.Parse(input);
            if (numberInput < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else
            {
                Console.WriteLine("This number is big enough");
            }
            //
            //Exercise 5: Create a menu program that allows a user to choose an option.
            // You get to decide on the options and output.After a choice is made, display 
            // some output in response to that choice. As long as the user does not choose
            // to exit, keep on prompting for a choice. Utilize a switch statement instead 
            //    of if/else if's to determine the users choice

            // Example Output :
            // Select a course to see the title:
            // A.CPW 150
            // B.CPW 116
            // C.CPW 212
            // D.CPW 210
            // Enter your choice:
            //Display output for choice. Ex. CPW 150 = Principles of Relational Database

            //Redisplay menu and prompt again for choice.
        }
    }
}
