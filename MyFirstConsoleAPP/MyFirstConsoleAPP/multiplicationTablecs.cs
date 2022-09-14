using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class multiplicationTablecs
    {
        static void Main()
        {
            Console.WriteLine("Enter the Number to find multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            { 
                Console.WriteLine(number*i);
            }
        }
    }
}
