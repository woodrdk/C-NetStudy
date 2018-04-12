﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructuresSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Today;
            DayOfWeek dow = currentDate.DayOfWeek;
            // next line is single line version of previous 2 lines
            DayOfWeek dow2 = DateTime.Today.DayOfWeek;
            // instead of large list of else ifs to check day of week we can use a switch statement

            switch (dow)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Taco Tuesday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Hamburger Wednesday");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Today we are serving Pizza Boy Pizza!");
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
            }
            /*
            if (dow == DayOfWeek.Monday)
            {

            }
            else if (dow == DayOfWeek.Tuesday)
            {
            }
            */
            #region MyRegion

            /*
            Console.WriteLine("What is your age? ");
            string input = Console.ReadLine();
            byte age = Convert.ToByte(input);
            // or makes lines 14 & 15 byte age = Convert.ToByte)Console.ReadLine());

            if (age >= 17)
            {
                Console.WriteLine("You can see this R rated movie");   
            }
            else
            {
                Console.WriteLine("You are too young for this movie");
            }
            */
            #endregion

            // the next line is just to keep the window open
            Console.ReadKey();
            
        }
    }
}
