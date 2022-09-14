using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class swap
    {
        static void Main()
        {
            Console.WriteLine("Enter the two number to swap");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("Number after swap: " + x + " and " + y);
        }
    }
}
