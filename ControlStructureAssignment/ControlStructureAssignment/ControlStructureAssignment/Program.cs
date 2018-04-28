using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

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
            if (numberInput < 10)
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
            double tally = 0;
            int userTotal = 0;
            string repeat = "y";
            while (repeat.Equals("y"))
            {
                tally++;
                Console.WriteLine("Enter an integer");
                string userInput = Console.ReadLine();
                int intInput = Int32.Parse(userInput);
                if (intInput < 10)
                {
                    Console.WriteLine("This number is too small");
                }
                else
                {
                    Console.WriteLine("This number is big enough");
                }
                Console.WriteLine("Do you want to continue? (y/n) ");
                repeat = Console.ReadLine();
                repeat = repeat.ToLower();
                userTotal += intInput;
            }
           
            Console.WriteLine("You added " + tally + " numbers together");
            Console.WriteLine("The total is " + userTotal);
            Console.WriteLine("The average is " + userTotal / tally );
            Console.ReadKey();



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
            Console.WriteLine();
            Console.WriteLine("Exercise 5");


            string repeatClasses = "y";
            while (repeatClasses.Equals("y"))
            {
                Console.WriteLine();
                Console.WriteLine("Select a course to see the title: ");
                Console.WriteLine("A. CPW 150");
                Console.WriteLine("B. CPW 116");
                Console.WriteLine("C. CPW 212");
                Console.WriteLine("D. CPW 210");
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine();
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "a":
                        Console.WriteLine("CPW 150 = Principles of Relational Database");
                        break;
                    case "b":
                        Console.WriteLine("CPW 116 = .NET PROGRAMMING");
                        break;
                    case "c":
                        Console.WriteLine("CPW 212 = ADVANCED .NET PROGRAMMING");
                        break;
                    case "d":
                        Console.WriteLine("CPW 210 = ADVANCED DATABASE PROGRAMMING");
                        break;
                    default:
                        Console.WriteLine("You did not pick a valid option");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Want to look again? (y/n)");
                repeatClasses = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
