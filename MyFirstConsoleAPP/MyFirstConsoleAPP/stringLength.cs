using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class stringLength
    {
        static void Main()
        {
            string str; /* Declares a string of size 100 */
            int l = 0;

         
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}\n\n", l);
        }
    }
}
