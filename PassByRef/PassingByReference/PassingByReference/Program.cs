using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            //double robsNum = 10;
            //Console.WriteLine($"Before - Robs Num: {robsNum}");
            //robsNum = DoubleNumber(robsNum);
            //Console.WriteLine($"After - Robs Num: {robsNum}");

            double myNum = 10;
            Console.WriteLine($"Before Num: {myNum}");
            DoubleNumRef(ref myNum);
            Console.WriteLine($"After Num: {myNum}");

            Console.ReadKey();
        }

        private static void DoubleNumRef(ref double yourNumber)
        {
            yourNumber *= 2;
        }


        private static double DoubleNumber (double yourNumber)
        {
            return yourNumber * 2;
        }
        
    }
}
