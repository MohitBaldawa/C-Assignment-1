using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class divisibleBy7
    {
        static void Main()
        {
            for (int i = 200; i <= 300; i++)
            {
                if(i%7 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
