using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class stringEqual
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word: ");

            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second word: ");

            string s2 = Console.ReadLine();


            // Equals() method return true
            // as both string objects are equal
            if (s1.Equals(s2))
                Console.WriteLine("Both the string are equal");
            else
                Console.WriteLine("Both string are not equal");
        }
    }
}
