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

            Student s1 = new Student();
            Student s2 = new Student(1, "Jane");
        }
    }

    class Person
    {
        int age = 20;

        //default ctor
        public Person()
        {
            Console.WriteLine(age);
            Console.ReadLine();
        }

        //paramaterised ctor
        public Person(int age, int yearBorn)
        {
            Console.WriteLine(age);
            Console.WriteLine(yearBorn);
            Console.ReadLine();
        }

        //static ctor
        static Person()
        {
            int AcedYear = 2002;
            Console.WriteLine("Current acedemic year: " + AcedYear);
            Console.ReadLine();
        }

    }

    class Student
    {
        //default const
        public Student()
        {
            Console.WriteLine("Im a constructor");
        }

        //parameterised
        public Student(int num, string name)
        {
            Console.WriteLine("Im a parameterised constructor");
            Console.Write(num);
            Console.Write(name);
            Console.ReadLine();
        }
    }
}
