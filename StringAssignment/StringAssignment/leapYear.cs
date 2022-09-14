using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class leapYear
    {
        static void Main()
        {
            int year;
            Console.WriteLine("Enter a year: ");
            year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine(year+" is a leap year.");
            }
            
            else if (year % 100 == 0)
            {
                Console.WriteLine(year+" is not a leap year.");
            }

            else if (year % 4 == 0)
            {
                Console.WriteLine(year+" is a leap year.");
            }
            // all other years are not leap years
            else
            {
                Console.WriteLine(year+" is not a leap year.");
            }
        }
    }
}
