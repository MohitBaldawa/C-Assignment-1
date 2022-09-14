using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class DisplayNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
