using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct Employee
    {
        public int Id;
        public string Name;
        public int SalaryRate;
        public int HoursWorked;

        public void CalculatedSalary()
        {
            int total = SalaryRate * HoursWorked;
            Console.WriteLine("Salary for the day is: " + total);

        }


        public struct Job
        {
            public string EmployerName;
            public string ClearanceLvl;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee.Job currentJob = new Employee.Job();
            emp.Id = 1;
            emp.Name = "Dean";
            emp.SalaryRate = 20;
            emp.HoursWorked = 5;
            currentJob.EmployerName = "ABC Company";
            
            emp.CalculatedSalary();

            Console.WriteLine("Salary paid by: " + currentJob.EmployerName); ;
            
            Console.ReadLine();
        }
    }
}

/*Notes: 
 * Nested Struct need to be called with its parent.  
 * Struct and nested can not acccess each others properties.
 */
