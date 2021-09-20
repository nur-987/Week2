using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// create a calculator to perform different arithmetic operation . 
    /// PART 1: calculate how many operations have been executed using only one counter.
    /// PART 2: what are they?
    /// </summary>
    class Program
    {
        public static int a = 20;
        public static int b = 10;

        static void Main(string[] args)
        {
            Class1 newClass = new Class1();
            newClass.Add(a, b);
            newClass.Subtraction(a, b);
            newClass.Multiply(a, b);
            newClass.Divide(a, b);
            newClass.Display();

            Console.ReadLine();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press (1) for Addition");
            Console.WriteLine("Press (2) for Subtraction");
            Console.WriteLine("Press (3) for Multiplication");
            Console.WriteLine("Press (4) for Division");
            Console.WriteLine("Press (5) for COUNTER");

            int input = Int32.Parse(Console.ReadLine());

            if (input == 1)
            {
                //AskNumber();
                newClass.Add(a, b);

            }
            else if (input == 2)
            {
                newClass.Subtraction(a, b);

            }
            else if (input == 3)
            {
                newClass.Multiply(a, b);


            }
            else if (input == 4)
            {
                newClass.Divide(a, b);

            }
            else
            {
                newClass.Display();
            }
        }
    }
}
