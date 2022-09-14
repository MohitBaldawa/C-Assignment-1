using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class EvenOdd
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number to check even or odd");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine(a + " is even number");
            else
                Console.WriteLine(a + " is odd number");
        }
    }
}
