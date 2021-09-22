using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeDifference
{
    /// <summary>
    /// Find the time difference between SG and another time zone.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time1 = DateTime.Now;
            DateTime time2 = new DateTime(2021, 09, 22, 15, 00, 00);
            TimeSpan timeDif = time1 - time2;
            Console.WriteLine("Total time diference is: " + timeDif.TotalHours);
            Console.ReadLine();
        }

    }
}
