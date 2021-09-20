using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// STACK pop and push
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            Stack myStack = new Stack();
            myStack.Push("James");
            myStack.Push("Henry");
            myStack.Push("Sam");

            foreach (string x in myStack)
            {
                Console.WriteLine(x);
            }

            myStack.Pop();
            Console.WriteLine("After pop");
            foreach (string x in myStack)
            {
                Console.WriteLine(x);
            }

            myStack.Push("Haily");
            myStack.Push("Ben");
            myStack.Push("Josh");

            Console.WriteLine("Added new names");

            Stack myStack2 = (Stack)myStack.Clone();

            Console.WriteLine("After clone");
            foreach (string x in myStack2)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();


        }
    }
}
