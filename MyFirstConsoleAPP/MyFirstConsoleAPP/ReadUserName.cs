using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleAPP
{
    internal class ReadUserName
    {
        static void Main()
        {
            Console.WriteLine("Enter username:");


            string userName = Console.ReadLine();


            Console.WriteLine("Hi! " + userName +"\nWelcome to the world of C#");
        }
            
    }
}
