using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class printSeries
    {
        static void Main()
        {
            int i = 1;
            while (i <= 25)
            {
                Console.WriteLine(i * i);
                i++;
            }
        }
    }
}
