using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class largestOfThreeNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine(a + " is greater");

            if (b > a && b > c)
                Console.WriteLine(b + " is greater");

            if (c > a && c > b)
                Console.WriteLine(c + " is greater");
        }
    }
}
