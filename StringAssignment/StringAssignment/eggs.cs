using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class eggs
    {
        static void Main()
        {
            Console.WriteLine("Enter the total eggs: ");
            int eggs = int.Parse(Console.ReadLine());

            int gross = eggs / 144;
            int aboveGross = eggs % 144;

            int dozens = aboveGross / 12;
            int extras = aboveGross % 12;

            Console.WriteLine("Your number of eggs is "+gross+" gross "+dozens+" dozens "+extras);


        }
    }
}
