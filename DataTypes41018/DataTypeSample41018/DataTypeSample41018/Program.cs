using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeSample41018
{
    class Program
    {
        static void Main(string[] args)
        {
            string numString = "5";         // following line converts this string to a int
            int thisNumber = Convert.ToInt32(numString);
            Console.WriteLine(thisNumber);
            string path = "c:\\Program Files\\Files";
            string path2 = @"c:\Program Files\Files"; // the @ makes literal verbatim string no escape sequences needed

            double total = 9.95;
            string displayCharge = "Price: $" + total;
            Console.WriteLine(displayCharge);

            // another way to do total display charge using .net framework is below
            // adds currency symbol based on your computers settings & rounds for us
            string displayCharge2 = "Price: " + total.ToString("c");
            Console.WriteLine(displayCharge2);
         
            // interpolated string is line below C# 6 feature
            string displayCharge3 = $"price: {total:c}";
            Console.WriteLine(displayCharge3);
            Console.ReadKey();

            // strings are immutable, meaning they cannot be changed
            string rob = "Robert Wood";
            rob = rob.ToUpper();
            Console.WriteLine(rob);
            // shortcut to type Console.WriteLine type cw then press tab-tab
            string stuff = null; // makes the string have no value
            string aaa = "";
            string bbb = string.Empty;
            string output = aaa + bbb;

            // Console.ReadKey();

            short zxc = 300;
            byte asd = (byte) zxc;
           
            int grade = (int) 93.75; // casts 93.75 to an int

            byte smallNum = 255;        // with the line below
            short largerNum = smallNum; // converts smallNum byte to largerNum short

            int qwerty = 32;            // with the line below
            decimal test = qwerty;      // converts int qwerty to decimal test

            const double TaxRate = .099; // constant is a variable that cannot be changed
            double testTotal = 100 * (TaxRate + 1);

            int counter; // all numbers default to 0
            byte age = 30;
            string name = "joe";
            char firstInitial = 'J';
            int largeNum = 345345;
            short numStudentsInDotNet = 5;

            float myNum = 3.14F; // can be upper case or lower case f
            double someNum = 9.99;

            bool isThisCool = true;
            char isThisCool2 = 'y'; // not ideal way to do a yes no ... use true false
            
            
            // Dont use .NET types in C#
            Byte age2 = 30;
            String name2 = "joe";
            Char firstInitial2 = 'J';
            Int16 num2 = 5;
            Int32 largeNum2 = 345345;
            Single myNum2 = 3.14f;
            Double someNum2 = 9.99;
            Boolean isThisCool3 = true;


        }
    }
}
