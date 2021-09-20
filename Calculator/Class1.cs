using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Class1
    {
        public static int counter = 0;
        public void Add(int a, int b)
        {
            Console.Write("Answer is: ");
            Console.Write(a + b);
            counter++;
            Console.ReadLine();
        }
        public void Subtraction(int a, int b)
        {
            Console.Write("Answer is: ");
            Console.Write(a - b);
            counter++;
            Console.ReadLine();
        }
        public void Multiply(int a, int b)
        {
            Console.Write("Answer is: ");
            Console.Write(a * b);
            counter++;
            Console.ReadLine();

        }
        public void Divide(int a, int b)
        {
            Console.Write("Answer is: ");
            Console.Write(a / b);
            counter++;
            Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine(counter);
        }
    }
}
