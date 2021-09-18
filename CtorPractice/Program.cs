using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtorPractice
{
    /// <summary>
    /// Default Constructor
    /// Parameterised Constructor
    /// Static Constructor
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Person paramP = new Person(25, 1998);
        }
    }

    class Person
    {
        int age = 20;

        public Person()
        {
            Console.WriteLine(age);
            Console.ReadLine();
        }
        public Person(int age, int yearBorn)
        {
            Console.WriteLine(age);
            Console.WriteLine(yearBorn);
            Console.ReadLine();
        }

        static Person()
        {
            int AcedYear = 2002;
            Console.WriteLine("Current acedemic year: " + AcedYear);
            Console.ReadLine();
        }

    }
}
